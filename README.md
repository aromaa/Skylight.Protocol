# Skylight.Protocol
Abstraction for virtual world game protocol to allow the possibility of supporting modern clients and decades old one's with the same network stack.

## Note
To allow innovation and adaptation to newer client versions, this library doesn't provide binary compatibility in any version. You are indented to pin to specific version.

## Design
Supporting multiple versions of incoming packets is quite simple. We are only dealing with single client whos data can be mapped to single universal representation. After the data has been correctly mapped it can be passed on to the actual packet handler who can use the universal representation to read the data.

The library represents incoming packets as interfaces to allow more flexible way to implement the actual mapping. This way the actual implementation can be simple object storage or possible direct read to the socket buffer.

However, supporting multiple versions of outgoing packets gets complicated. We need to have enough data so that the packet can be interpreted for ALL client versions. We also need to take into account how different versions expect this data to be formatted or how even the protocol itself represents this data. This needs to be taken into account on how the structure of the abstraction looks like.

Additionally some clients might even be missing whole packets or fields which might result in to the client rendering incomplete scenario. You could try to simulate the effects by using different combination of packets supported by the client but ultimately the library doesn't take this into account and leaves it up to the implementer. 

The library represents outgoing packets as classes that have the combined fields of all the possible clients. This also includes abstractions that might not do anything at all for modern clients. This way a single packet can be mapped to every client by using the same object.

## Protocol representation
Supporting multiple different protocols can very easily and fast become burden and making changes to the networking code base could become hard or even impossible. To avoid this issue, every protocol version defines a `packets.json` that defines how the universal representation is mapped on the network level. Then the project `Skylight.Protocol.Generator` is used to generate the actual network code. This way the network layer can be adjusted later on and new features, improvements and optimizations can be applied to every version with ease.

There are plans to make some kind of small (web) UI to manipulate the protocol definition more naturally.

## Documentation
The most difficult part of supporting multiple versions is that there are subtle differences. At the moment there are few attributes like `IntroducedIn`, `RemovedOn` and `Aliases` to help mark which packets or their fields are actually used on which version but hopefully we could add more extensive comments to the actual protocol definition files. This way we could also generate nice markdown files in the future.

## Workflow
1. The universal packet definitions can be found in the `Skylight.Protocol` project under `Packets` folder. Any new packet needs to be added here first.
2. After the universal definition exits we can add a protocol specific mapping for it. These are inside the `Skylight.Protocol.X` folder with the `Skylight.Protocol.<PROTOCOL>` prefix. The mapping can be added by modifying the `packets.json` file and then running the generator which creates the necessary files.
3. If you would not like to work with raw json files you can use the `Skylight.Protocol.Editor` which provides WinForms based application to manipulate these files. Upon opening the application change the working path to point to the `Skylight.Protocol.X` directory. You should see list of all the protocols now.
4. Select the protocol(s) you would like to work on and make the necessary changes. After you are done you can click the save button which updates the files on disk and automatically runs the generator.
5. In addition to allow the detection of changes made to `Skylight.Protocol` appear without recompiling the editor you can move the editor application files from `Skylight.Protocol.Editor\bin` to `Skylight.Protocol\bin`. Now once you have changed the `Skylight.Protocol` and recompiled it, the editor should pick up these changes.
