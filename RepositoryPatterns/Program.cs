

using FactoryPattern;

INotification notification= NotificationFactory.CreateNotification("Email");

notification.NotifyMessage("Hi I am from Email Message");



