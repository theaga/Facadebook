namespace FacebookAbstractions.Web
{
    /// <summary>
    /// This interface represents a class that can be used
    /// as a facade for the native FacebookWebClient class.
    /// </summary>
    public interface IFacebookWebClientFacade
    {
        bool IsSecureConnection { get; set; }
    }
}