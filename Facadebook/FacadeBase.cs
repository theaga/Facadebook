namespace Facadebook
{
    /// <summary>
    /// This class can be used to wrap any base class
    /// within a facade.
    /// </summary>
    /// <remarks>
    /// Author:     Daniel Saidi [daniel.saidi@gmail.com]
    /// Link:       http://www.saidi.se/netextensions
    /// </remarks>
    /// <typeparam name="T">The type that is to be facaded.</typeparam>
    public class FacadeBase<T>
    {
        /// <summary>
        /// Create an instance of the class.
        /// </summary>
        /// <param name="baseInstance">The base instance that the class should be a facade for.</param>
        public FacadeBase(T baseInstance)
        {
            BaseInstance = baseInstance;
        }


        /// <summary>
        /// The base instance that the class is a facade for.
        /// </summary>
        protected T BaseInstance { get; set; }
    }
}
