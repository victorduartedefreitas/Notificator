using Notificator.Notifications;
using Notificator.Validations.Rules;

namespace Notificator.Validations
{
    public partial class Validation<TEntity>
        where TEntity : class, INotifiable
    {
        #region Decimal Rules

        public Validation<TEntity> IsGreaterThan(decimal value, decimal compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new DecimalGreaterThanOrEqualsRule(value, compareTo, false, true, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsGreaterThanOrEquals(decimal value, decimal compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new DecimalGreaterThanOrEqualsRule(value, compareTo, true, true, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsLowerThan(decimal value, decimal compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new DecimalGreaterThanOrEqualsRule(value, compareTo, false, false, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsLowerThanOrEquals(decimal value, decimal compareTo, string notificationKey = "IsLowerThanOrEqualsRuleViolation", string notificationMessage = "IsLowerThanOrEqualsRuleViolation")
        {
            _rules.Add(new DecimalGreaterThanOrEqualsRule(value, compareTo, true, false, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> AreEquals(decimal value, decimal compareTo, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new DecimalEqualsRule(value, compareTo, true, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> AreNotEquals(decimal value, decimal compareTo, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new DecimalEqualsRule(value, compareTo, false, notificationKey, notificationMessage));
            return this;
        }

        #endregion

        #region Double Rules

        public Validation<TEntity> IsGreaterThan(double value, double compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new DoubleGreaterThanOrEqualsRule(value, compareTo, false, true, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsGreaterThanOrEquals(double value, double compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new DoubleGreaterThanOrEqualsRule(value, compareTo, true, true, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsLowerThan(double value, double compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new DoubleGreaterThanOrEqualsRule(value, compareTo, false, false, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsLowerThanOrEquals(double value, double compareTo, string notificationKey = "IsLowerThanOrEqualsRuleViolation", string notificationMessage = "IsLowerThanOrEqualsRuleViolation")
        {
            _rules.Add(new DoubleGreaterThanOrEqualsRule(value, compareTo, true, false, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> AreEquals(double value, double compareTo, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new DoubleEqualsRule(value, compareTo, true, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> AreNotEquals(double value, double compareTo, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new DoubleEqualsRule(value, compareTo, false, notificationKey, notificationMessage));
            return this;
        }

        #endregion

        #region Float Rules

        public Validation<TEntity> IsGreaterThan(float value, float compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new FloatGreaterThanOrEqualsRule(value, compareTo, false, true, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsGreaterThanOrEquals(float value, float compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new FloatGreaterThanOrEqualsRule(value, compareTo, true, true, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsLowerThan(float value, float compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new FloatGreaterThanOrEqualsRule(value, compareTo, false, false, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsLowerThanOrEquals(float value, float compareTo, string notificationKey = "IsLowerThanOrEqualsRuleViolation", string notificationMessage = "IsLowerThanOrEqualsRuleViolation")
        {
            _rules.Add(new FloatGreaterThanOrEqualsRule(value, compareTo, true, false, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> AreEquals(float value, float compareTo, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new FloatEqualsRule(value, compareTo, true, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> AreNotEquals(float value, float compareTo, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new FloatEqualsRule(value, compareTo, false, notificationKey, notificationMessage));
            return this;
        }

        #endregion

        #region ULong Rules

        public Validation<TEntity> IsGreaterThan(ulong value, ulong compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new UInt64GreaterThanOrEqualsRule(value, compareTo, false, true, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsGreaterThanOrEquals(ulong value, ulong compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new UInt64GreaterThanOrEqualsRule(value, compareTo, true, true, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsLowerThan(ulong value, ulong compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new UInt64GreaterThanOrEqualsRule(value, compareTo, false, false, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsLowerThanOrEquals(ulong value, ulong compareTo, string notificationKey = "IsLowerThanOrEqualsRuleViolation", string notificationMessage = "IsLowerThanOrEqualsRuleViolation")
        {
            _rules.Add(new UInt64GreaterThanOrEqualsRule(value, compareTo, true, false, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> AreEquals(ulong value, ulong compareTo, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new UInt64EqualsRule(value, compareTo, true, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> AreNotEquals(ulong value, ulong compareTo, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new UInt64EqualsRule(value, compareTo, false, notificationKey, notificationMessage));
            return this;
        }

        #endregion

        #region Long Rules

        public Validation<TEntity> IsGreaterThan(long value, long compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new Int64GreaterThanOrEqualsRule(value, compareTo, false, true, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsGreaterThanOrEquals(long value, long compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new Int64GreaterThanOrEqualsRule(value, compareTo, true, true, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsLowerThan(long value, long compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new Int64GreaterThanOrEqualsRule(value, compareTo, false, false, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsLowerThanOrEquals(long value, long compareTo, string notificationKey = "IsLowerThanOrEqualsRuleViolation", string notificationMessage = "IsLowerThanOrEqualsRuleViolation")
        {
            _rules.Add(new Int64GreaterThanOrEqualsRule(value, compareTo, true, false, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> AreEquals(long value, long compareTo, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new Int64EqualsRule(value, compareTo, true, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> AreNotEquals(long value, long compareTo, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new Int64EqualsRule(value, compareTo, false, notificationKey, notificationMessage));
            return this;
        }

        #endregion

        #region UInt Rules

        public Validation<TEntity> IsGreaterThan(uint value, uint compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new UInt32GreaterThanOrEqualsRule(value, compareTo, false, true, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsGreaterThanOrEquals(uint value, uint compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new UInt32GreaterThanOrEqualsRule(value, compareTo, true, true, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsLowerThan(uint value, uint compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new UInt32GreaterThanOrEqualsRule(value, compareTo, false, false, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsLowerThanOrEquals(uint value, uint compareTo, string notificationKey = "IsLowerThanOrEqualsRuleViolation", string notificationMessage = "IsLowerThanOrEqualsRuleViolation")
        {
            _rules.Add(new UInt32GreaterThanOrEqualsRule(value, compareTo, true, false, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> AreEquals(uint value, uint compareTo, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new UInt32EqualsRule(value, compareTo, true, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> AreNotEquals(uint value, uint compareTo, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new UInt32EqualsRule(value, compareTo, false, notificationKey, notificationMessage));
            return this;
        }

        #endregion

        #region Int Rules

        public Validation<TEntity> IsGreaterThan(int value, int compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new Int32GreaterThanOrEqualsRule(value, compareTo, false, true, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsGreaterThanOrEquals(int value, int compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new Int32GreaterThanOrEqualsRule(value, compareTo, true, true, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsLowerThan(int value, int compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new Int32GreaterThanOrEqualsRule(value, compareTo, false, false, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsLowerThanOrEquals(int value, int compareTo, string notificationKey = "IsLowerThanOrEqualsRuleViolation", string notificationMessage = "IsLowerThanOrEqualsRuleViolation")
        {
            _rules.Add(new Int32GreaterThanOrEqualsRule(value, compareTo, true, false, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> AreEquals(int value, int compareTo, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new Int32EqualsRule(value, compareTo, true, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> AreNotEquals(int value, int compareTo, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new Int32EqualsRule(value, compareTo, false, notificationKey, notificationMessage));
            return this;
        }

        #endregion

        #region UShort Rules

        public Validation<TEntity> IsGreaterThan(ushort value, ushort compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new UInt16GreaterThanOrEqualsRule(value, compareTo, false, true, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsGreaterThanOrEquals(ushort value, ushort compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new UInt16GreaterThanOrEqualsRule(value, compareTo, true, true, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsLowerThan(ushort value, ushort compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new UInt16GreaterThanOrEqualsRule(value, compareTo, false, false, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsLowerThanOrEquals(ushort value, ushort compareTo, string notificationKey = "IsLowerThanOrEqualsRuleViolation", string notificationMessage = "IsLowerThanOrEqualsRuleViolation")
        {
            _rules.Add(new UInt16GreaterThanOrEqualsRule(value, compareTo, true, false, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> AreEquals(ushort value, ushort compareTo, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new UInt16EqualsRule(value, compareTo, true, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> AreNotEquals(ushort value, ushort compareTo, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new UInt16EqualsRule(value, compareTo, false, notificationKey, notificationMessage));
            return this;
        }

        #endregion

        #region Short Rules

        public Validation<TEntity> IsGreaterThan(short value, short compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new Int16GreaterThanOrEqualsRule(value, compareTo, false, true, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsGreaterThanOrEquals(short value, short compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new Int16GreaterThanOrEqualsRule(value, compareTo, true, true, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsLowerThan(short value, short compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new Int16GreaterThanOrEqualsRule(value, compareTo, false, false, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsLowerThanOrEquals(short value, short compareTo, string notificationKey = "IsLowerThanOrEqualsRuleViolation", string notificationMessage = "IsLowerThanOrEqualsRuleViolation")
        {
            _rules.Add(new Int16GreaterThanOrEqualsRule(value, compareTo, true, false, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> AreEquals(short value, short compareTo, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new Int16EqualsRule(value, compareTo, true, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> AreNotEquals(short value, short compareTo, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new Int16EqualsRule(value, compareTo, false, notificationKey, notificationMessage));
            return this;
        }

        #endregion

        #region Byte Rules

        public Validation<TEntity> IsGreaterThan(byte value, byte compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new ByteGreaterThanOrEqualsRule(value, compareTo, false, true, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsGreaterThanOrEquals(byte value, byte compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new ByteGreaterThanOrEqualsRule(value, compareTo, true, true, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsLowerThan(byte value, byte compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new ByteGreaterThanOrEqualsRule(value, compareTo, false, false, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsLowerThanOrEquals(byte value, byte compareTo, string notificationKey = "IsLowerThanOrEqualsRuleViolation", string notificationMessage = "IsLowerThanOrEqualsRuleViolation")
        {
            _rules.Add(new ByteGreaterThanOrEqualsRule(value, compareTo, true, false, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> AreEquals(byte value, byte compareTo, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new ByteEqualsRule(value, compareTo, true, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> AreNotEquals(byte value, byte compareTo, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new ByteEqualsRule(value, compareTo, false, notificationKey, notificationMessage));
            return this;
        }

        #endregion
    }
}
