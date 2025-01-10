

using DecratorPattern;

INotification notification = new EmailNotification();
Console.WriteLine("Basic Notification");
notification.send("Hello User..!");

Console.WriteLine("sms Notification");
notification =new SMSNotification(notification);
notification.send("Hello i am from sms");

Console.WriteLine("push Notification");
notification = new PushNotification(notification);
notification.send("Hello i am from email");


