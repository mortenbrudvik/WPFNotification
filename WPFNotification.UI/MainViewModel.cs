using Microsoft.Toolkit.Uwp.Notifications;

namespace WPFNotification.UI
{
    public class MainViewModel
    {
        public DelegateCommand ShowNotificationCommand => new DelegateCommand(x => ShowNotification());

        // https://docs.microsoft.com/en-us/windows/uwp/design/shell/tiles-and-notifications/send-local-toast?tabs=uwp
        private static void ShowNotification()
        {
            new ToastContentBuilder()
                .AddArgument("action", "viewConversation")
                .AddArgument("conversationId", 9813)
                .AddText("WPFNotification App")
                .AddText("Hello!")
                .Show();
        }
    }
}