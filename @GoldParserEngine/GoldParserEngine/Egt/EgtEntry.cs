using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldParser.Egt
{
	public enum EgtEntryType
	{
		Empty = 69,
		UInt16 = 73,
		String = 83,
		Boolean = 66,
		Byte = 98,
		Error = 0
	}
	public class EgtEntry
	{
		private EgtEntryType _type;
		private object _value;

		public EgtEntry()
		{
			_type = EgtEntryType.Empty;
			_value = null;
		}
		public EgtEntry(EgtEntryType type, object value)
		{
			_type = type;
			_value = value;
		}


		public EgtEntryType Type
		{
			get
			{
				return _type;
			}
		}
		public bool IsEmpty()
        {
			return _type == EgtEntryType.Empty;
        }
		public bool IsError()
		{
			return _type == EgtEntryType.Error;
		}
		public int? GetInt()
		{
			if (_value != null && _value is ushort)
			{
				return (UInt16)_value;
			}
			return null;
		}
		public bool? GetBool()
		{
			if(_value != null && _value is bool)
            {
				return (bool)_value;
            }
			return null;
		}
		public byte? GetByte()
		{
			if (_value != null && _value is byte)
			{
				return (byte)_value;
			}
			return null;
		}
		public string GetString()
		{
			if (_value != null && _value is string)
			{
				return (string)_value;
			}
			return null;
		}
	}
}
