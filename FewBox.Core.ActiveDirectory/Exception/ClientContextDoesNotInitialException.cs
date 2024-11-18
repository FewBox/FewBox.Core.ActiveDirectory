namespace FewBox.Core.ActiveDirectory.Exception
{
    public class ClientContextDoesNotInitialException : System.Exception
    {
        public ClientContextDoesNotInitialException() :
            base(@"FewBox Team: Please init your client context first. - ClientContext.Init([Path], [Username], [Password])") {
        }
    }
}
