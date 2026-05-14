export function downloadFileBlob(fileName, contentType, content)
{
	const file = new File([content], fileName, { type: contentType });
	const url = URL.createObjectURL(file);

	const dummy = document.createElement("a");
	dummy.href = url;
	dummy.download = fileName;
	dummy.click();
	dummy.remove();

	URL.revokeObjectURL(url);
}
