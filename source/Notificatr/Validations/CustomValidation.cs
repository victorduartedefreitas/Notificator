using Notificatr.Notifications;
using Notificatr.Validations.Rules;
using System;

namespace Notificatr.Validations
{
    public partial class Validation<TEntity>
        where TEntity : class, INotifiable
    {
        /// <summary>
        /// Provide a custom rule for validation.
        /// You have to create a class that inherits CustomRule abstract class, and then pass this class as the type from this method.
        /// </summary>
        /// <typeparam name="TCustomRule">CustomRule implementation class</typeparam>
        /// <param name="parameters">Parameters for CustomRule implementation</param>
        /// <returns></returns>
        public Validation<TEntity> AddCustomRule<TCustomRule>(object[] parameters, string notificationKey, string notificationMessage)
            where TCustomRule : CustomRule
        {
            _rules.Add((TCustomRule)Activator.CreateInstance(typeof(TCustomRule), parameters, notificationKey, notificationMessage));
            return this;
        }
    }
}
