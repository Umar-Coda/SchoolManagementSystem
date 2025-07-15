namespace SchoolManagementSystemDesktop.Views;
public interface ILoginView {
    string Username { get; }
    string Password { get; }
    void ShowMessage(string message);
    void CloseForm();
    event EventHandler LoginClicked;
}

