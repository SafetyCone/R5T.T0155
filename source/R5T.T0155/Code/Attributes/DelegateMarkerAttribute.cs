using System;

using R5T.T0143;


namespace R5T.T0155
{
    /// <summary>
    /// Attribute indicating a delegate.
    /// The marker attribute is useful for surveying assemblies and code, then building a catalogue of delegates.
    /// </summary>
    [AttributeUsage(AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class DelegateMarkerAttribute : Attribute,
        IMarkerAttributeMarker
    {
        /// <summary>
        /// Allows specifying that a delegate is *not* a delegate (well... a delegate that should be surveyed).
        /// This is useful for marking delegates that end up canonical delegate code file locations, but are not actually delegates worthy of surveying.
        /// </summary>
        public bool IsDelegate { get; }


        public DelegateMarkerAttribute(
            bool isDelegate = true)
        {
            this.IsDelegate = isDelegate;
        }
    }
}
