using System;

internal class NetworkBuffer {
	public int Position;

	public byte[] Bytes;

	public NetworkBuffer()
	{
		Bytes = new byte[4];
	}

	public void Initialize(int newSize)
	{
		if (newSize > 1048576) {
			throw new ArgumentException("New buffer size is too large");
		}

		var array = Bytes;
		Bytes = new byte[newSize];
		Bytes[0] = array[0];
		Bytes[1] = array[1];
		Bytes[2] = array[2];
		Bytes[3] = array[3];
	}

	public void MovePosition(int numBytes)
	{
		Position += numBytes;
	}

	public void Reset()
	{
		Bytes = new byte[4];
		Position = 0;
	}

	public int BytesRemaining()
	{
		return Bytes.Length - Position;
	}

	public void Destroy()
	{
		Bytes = null;
	}
}