// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLClientDHInnerData : TLObject 
	{
		public TLInt128 Nonce { get; set; }
		public TLInt128 ServerNonce { get; set; }
		public Int64 RetryId { get; set; }
		public Byte[] GB { get; set; }

		public TLClientDHInnerData() { }
		public TLClientDHInnerData(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ClientDHInnerData; } }

		public override void Read(TLBinaryReader from)
		{
			Nonce = new TLInt128(from);
			ServerNonce = new TLInt128(from);
			RetryId = from.ReadInt64();
			GB = from.ReadByteArray();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x6643B654);
			to.WriteObject(Nonce);
			to.WriteObject(ServerNonce);
			to.Write(RetryId);
			to.WriteByteArray(GB);
		}
	}
}