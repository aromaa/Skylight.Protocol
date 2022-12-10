
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