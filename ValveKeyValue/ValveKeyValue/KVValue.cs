﻿using System;
using System.Globalization;

namespace ValveKeyValue
{
    /// <summary>
    /// Container type for value of a KeyValues object.
    /// </summary>
    public abstract class KVValue : IConvertible
    {
        /// <summary>
        /// Converts a <see cref="KVValue"/> to a <see cref="string"/>.
        /// </summary>
        /// <param name="value">The <see cref="KVValue"/> to convert.</param>
        public static explicit operator string(KVValue value)
        {
            return value?.ToString(null);
        }

        /// <summary>
        /// Converts a <see cref="KVValue"/> to a <see cref="bool"/>.
        /// </summary>
        /// <param name="value">The <see cref="KVValue"/> to convert.</param>
        public static explicit operator bool(KVValue value)
        {
            return value.ToBoolean(null);
        }

        /// <inheritdoc/>
        public abstract TypeCode GetTypeCode();

        /// <inheritdoc/>
        public abstract bool ToBoolean(IFormatProvider provider);

        /// <inheritdoc/>
        public abstract byte ToByte(IFormatProvider provider);

        /// <inheritdoc/>
        public abstract char ToChar(IFormatProvider provider);

        /// <inheritdoc/>
        public abstract DateTime ToDateTime(IFormatProvider provider);

        /// <inheritdoc/>
        public abstract decimal ToDecimal(IFormatProvider provider);

        /// <inheritdoc/>
        public abstract double ToDouble(IFormatProvider provider);

        /// <inheritdoc/>
        public abstract short ToInt16(IFormatProvider provider);

        /// <inheritdoc/>
        public abstract int ToInt32(IFormatProvider provider);

        /// <inheritdoc/>
        public abstract long ToInt64(IFormatProvider provider);

        /// <inheritdoc/>
        public abstract sbyte ToSByte(IFormatProvider provider);

        /// <inheritdoc/>
        public abstract float ToSingle(IFormatProvider provider);

        /// <inheritdoc/>
        public abstract string ToString(IFormatProvider provider);

        /// <inheritdoc/>
        public abstract object ToType(Type conversionType, IFormatProvider provider);

        /// <inheritdoc/>
        public abstract ushort ToUInt16(IFormatProvider provider);

        /// <inheritdoc/>
        public abstract uint ToUInt32(IFormatProvider provider);

        /// <inheritdoc/>
        public abstract ulong ToUInt64(IFormatProvider provider);
    }
}
