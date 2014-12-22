class hooksRestCalls
{
 internal static CallSpec eventTypes { get { return sr_eventTypes; } }
 private static readonly CallSpec sr_eventTypes= new CallSpec("_apis/hooks/publishers/{publisherId}/eventTypes/{eventTypeId}");
 internal static CallSpec publishers { get { return sr_publishers; } }
 private static readonly CallSpec sr_publishers= new CallSpec("_apis/hooks/publishers/{publisherId}");
 internal static CallSpec actions { get { return sr_actions; } }
 private static readonly CallSpec sr_actions= new CallSpec("_apis/hooks/consumers/{consumerId}/actions/{consumerActionId}");
 internal static CallSpec consumers { get { return sr_consumers; } }
 private static readonly CallSpec sr_consumers= new CallSpec("_apis/hooks/consumers/{consumerId}");
 internal static CallSpec notifications { get { return sr_notifications; } }
 private static readonly CallSpec sr_notifications= new CallSpec("_apis/hooks/subscriptions/{subscriptionId}/notifications/{notificationId}");
 internal static CallSpec testNotifications { get { return sr_testNotifications; } }
 private static readonly CallSpec sr_testNotifications= new CallSpec("_apis/hooks/testNotifications/{notificationId}");
 internal static CallSpec subscriptions { get { return sr_subscriptions; } }
 private static readonly CallSpec sr_subscriptions= new CallSpec("_apis/hooks/subscriptions/{subscriptionId}");
 internal static CallSpec publishersQuery { get { return sr_publishersQuery; } }
 private static readonly CallSpec sr_publishersQuery= new CallSpec("_apis/hooks/publishersQuery");
 internal static CallSpec subscriptionsQuery { get { return sr_subscriptionsQuery; } }
 private static readonly CallSpec sr_subscriptionsQuery= new CallSpec("_apis/hooks/subscriptionsQuery");
 internal static CallSpec notificationsQuery { get { return sr_notificationsQuery; } }
 private static readonly CallSpec sr_notificationsQuery= new CallSpec("_apis/hooks/notificationsQuery");
 internal static CallSpec inputValuesQuery { get { return sr_inputValuesQuery; } }
 private static readonly CallSpec sr_inputValuesQuery= new CallSpec("_apis/hooks/inputValuesQuery");
}
