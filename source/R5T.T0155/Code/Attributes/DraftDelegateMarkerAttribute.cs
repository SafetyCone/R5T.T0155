using System;

using R5T.T0143;


namespace R5T.T0155
{
    /// <summary>
    /// Attribute indicating a type is a draft delegate.
    /// Draft delegates are quickly created and should be reviewed and relocated, and thus become full delegates.
    /// The marker attribute is useful for surveying assemblies and code, then building a catalogue of draft Razor components as a kind of TODO list.
    /// </summary>
    [AttributeUsage(AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class DraftDelegateMarkerAttribute : Attribute,
        IMarkerAttributeMarker
    {
        /// <summary>
        /// Allows specifying that a delegate is *not* a draft delegate (well... a draft delegate that should be surveyed).
        /// This is useful for marking types that end up canonical draft delegate code file locations, but are not actually draft delegates worthy of surveying.
        /// </summary>
        public bool IsDraftDelegate { get; }


        public DraftDelegateMarkerAttribute(
            bool isDraftDelegate = true)
        {
            this.IsDraftDelegate = isDraftDelegate;
        }
    }
}
