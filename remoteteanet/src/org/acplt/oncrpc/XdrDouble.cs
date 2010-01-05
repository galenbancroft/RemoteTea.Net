namespace org.acplt.oncrpc
{
	/// <summary>
	/// Instances of the class <code>XdrDouble</code> represent (de-)serializeable
	/// doubles, which are especially useful in cases where a result with only a
	/// single double is expected from a remote function call or only a single
	/// double parameter needs to be supplied.
	/// </summary>
	/// <remarks>
	/// Instances of the class <code>XdrDouble</code> represent (de-)serializeable
	/// doubles, which are especially useful in cases where a result with only a
	/// single double is expected from a remote function call or only a single
	/// double parameter needs to be supplied.
	/// <p>Please note that this class is somewhat modelled after Java's primitive
	/// data type wrappers. As for these classes, the XDR data type wrapper classes
	/// follow the concept of values with no identity, so you are not allowed to
	/// change the value after you've created a value object.
	/// </remarks>
	/// <version>$Revision: 1.1.1.1 $ $Date: 2003/08/13 12:03:44 $ $State: Exp $ $Locker:  $
	/// 	</version>
	/// <author>Harald Albrecht</author>
	public class XdrDouble : org.acplt.oncrpc.XdrAble
	{
		/// <summary>Constructs and initializes a new <code>XdrDouble</code> object.</summary>
		/// <remarks>Constructs and initializes a new <code>XdrDouble</code> object.</remarks>
		/// <param name="value">Double value.</param>
		public XdrDouble(double value)
		{
			this.value = value;
		}

		/// <summary>Constructs and initializes a new <code>XdrDouble</code> object.</summary>
		/// <remarks>Constructs and initializes a new <code>XdrDouble</code> object.</remarks>
		public XdrDouble()
		{
			this.value = 0;
		}

		/// <summary>
		/// Returns the value of this <code>XdrDouble</code> object as a double
		/// primitive.
		/// </summary>
		/// <remarks>
		/// Returns the value of this <code>XdrDouble</code> object as a double
		/// primitive.
		/// </remarks>
		/// <returns>The primitive <code>double</code> value of this object.</returns>
		public virtual double doubleValue()
		{
			return this.value;
		}

		/// <summary>
		/// Encodes -- that is: serializes -- a XDR double into a XDR stream in
		/// compliance to RFC 1832.
		/// </summary>
		/// <remarks>
		/// Encodes -- that is: serializes -- a XDR double into a XDR stream in
		/// compliance to RFC 1832.
		/// </remarks>
		/// <exception cref="OncRpcException">if an ONC/RPC error occurs.</exception>
		/// <exception cref="System.IO.IOException">if an I/O error occurs.</exception>
		/// <exception cref="org.acplt.oncrpc.OncRpcException"></exception>
		public virtual void xdrEncode(org.acplt.oncrpc.XdrEncodingStream xdr)
		{
			xdr.xdrEncodeDouble(value);
		}

		/// <summary>
		/// Decodes -- that is: deserializes -- a XDR double from a XDR stream in
		/// compliance to RFC 1832.
		/// </summary>
		/// <remarks>
		/// Decodes -- that is: deserializes -- a XDR double from a XDR stream in
		/// compliance to RFC 1832.
		/// </remarks>
		/// <exception cref="OncRpcException">if an ONC/RPC error occurs.</exception>
		/// <exception cref="System.IO.IOException">if an I/O error occurs.</exception>
		/// <exception cref="org.acplt.oncrpc.OncRpcException"></exception>
		public virtual void xdrDecode(org.acplt.oncrpc.XdrDecodingStream xdr)
		{
			value = xdr.xdrDecodeDouble();
		}

		/// <summary>The encapsulated double value itself.</summary>
		/// <remarks>The encapsulated double value itself.</remarks>
		private double value;
	}
}