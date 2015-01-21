using DynCon.OSI.JasonBackedObjects.Communications;

namespace DynCon.OSI.VSO.ReSTClient.RestCalls
{
    /// <summary>
    ///     Class HooksRestCalls.
    /// </summary>
    internal class HooksRestCalls
    {
        /*
        /hooks/consumers		GET		_apis/hooks/consumers?api-version=1.0
        /hooks/consumers/{consumerId}		GET		_apis/hooks/consumers/zendesk?api-version=1.0
        /hooks/consumers/{consumerId}/actions		GET		_apis/hooks/consumers/zendesk/actions?api-version=1.0
        /hooks/consumers/{consumerId}/actions/{consumerActionId}		GET		_apis/hooks/consumers/zendesk/actions/createPrivateComment?api-version=1.0
        /hooks/publishers		GET		_apis/hooks/publishers?api-version=1.0
        /hooks/publishers/{publisherId}/eventTypes		GET		_apis/hooks/publishers/tfs/eventTypes?api-version=1.0
        /hooks/publishers/{publisherId}/eventTypes/{eventTypeId}		GET		_apis/hooks/publishers/tfs/eventTypes/build.complete?api-version=1.0
        /hooks/subscriptions/{newSubscriptionId}		DELETE		_apis/hooks/subscriptions/fd672255-8b6b-4769-9260-beea83d752ce?api-version=1.0
        /hooks/subscriptions/		GET		_apis/hooks/subscriptions/?api-version=1.0
        /hooks/subscriptions/{subscriptionId}		GET		_apis/hooks/subscriptions/8dea9aba-3a9a-4ad0-860f-2a5c7379e3eb?api-version=1.0
        /hooks/subscriptions		POST		_apis/hooks/subscriptions?api-version=1.0
        /hooks/subscriptions/{newSubscriptionId}		PUT		_apis/hooks/subscriptions/fd672255-8b6b-4769-9260-beea83d752ce?api-version=1.0

         */
        /// <summary>
        ///     Gets the actions.
        /// </summary>
        /// <value>The actions.</value>
        internal static CallSpec Actions { get { return sr_Actions; } }

        /// <summary>
        ///     Gets the consumers.
        /// </summary>
        /// <value>The consumers.</value>
        internal static CallSpec Consumers { get { return sr_Consumers; } }

        /// <summary>
        ///     Gets the event types.
        /// </summary>
        /// <value>The event types.</value>
        internal static CallSpec EventTypes { get { return sr_EventTypes; } }

        /// <summary>
        ///     Gets the input values query.
        /// </summary>
        /// <value>The input values query.</value>
        internal static CallSpec InputValuesQuery { get { return sr_InputValuesQuery; } }

        /// <summary>
        ///     Gets the notifications.
        /// </summary>
        /// <value>The notifications.</value>
        internal static CallSpec Notifications { get { return sr_Notifications; } }

        /// <summary>
        ///     Gets the notifications query.
        /// </summary>
        /// <value>The notifications query.</value>
        internal static CallSpec NotificationsQuery { get { return sr_NotificationsQuery; } }

        /// <summary>
        ///     Gets the publishers.
        /// </summary>
        /// <value>The publishers.</value>
        internal static CallSpec Publishers { get { return sr_Publishers; } }

        /// <summary>
        ///     Gets the publishers query.
        /// </summary>
        /// <value>The publishers query.</value>
        internal static CallSpec PublishersQuery { get { return sr_PublishersQuery; } }

        /// <summary>
        ///     Gets the subscriptions.
        /// </summary>
        /// <value>The subscriptions.</value>
        internal static CallSpec Subscriptions { get { return sr_Subscriptions; } }

        /// <summary>
        ///     Gets the subscriptions query.
        /// </summary>
        /// <value>The subscriptions query.</value>
        internal static CallSpec SubscriptionsQuery { get { return sr_SubscriptionsQuery; } }

        /// <summary>
        ///     Gets the test notifications.
        /// </summary>
        /// <value>The test notifications.</value>
        internal static CallSpec TestNotifications { get { return sr_TestNotifications; } }

        /// <summary>
        ///     The SR_ actions
        /// </summary>
        private static readonly CallSpec sr_Actions = new CallSpec("_apis/hooks/consumers/{consumerId}/actions/{consumerActionId}");

        /// <summary>
        ///     The SR_ consumers
        /// </summary>
        private static readonly CallSpec sr_Consumers = new CallSpec("_apis/hooks/consumers/{consumerId}");

        /// <summary>
        ///     The SR_ event types
        /// </summary>
        private static readonly CallSpec sr_EventTypes = new CallSpec("_apis/hooks/publishers/{publisherId}/eventTypes/{eventTypeId}");

        /// <summary>
        ///     The SR_ input values query
        /// </summary>
        private static readonly CallSpec sr_InputValuesQuery = new CallSpec("_apis/hooks/inputValuesQuery");

        /// <summary>
        ///     The SR_ notifications
        /// </summary>
        private static readonly CallSpec sr_Notifications = new CallSpec("_apis/hooks/subscriptions/{subscriptionId}/notifications/{notificationId}");

        /// <summary>
        ///     The SR_ notifications query
        /// </summary>
        private static readonly CallSpec sr_NotificationsQuery = new CallSpec("_apis/hooks/notificationsQuery");

        /// <summary>
        ///     The SR_ publishers
        /// </summary>
        private static readonly CallSpec sr_Publishers = new CallSpec("_apis/hooks/publishers/{publisherId}");

        /// <summary>
        ///     The SR_ publishers query
        /// </summary>
        private static readonly CallSpec sr_PublishersQuery = new CallSpec("_apis/hooks/publishersQuery");

        /// <summary>
        ///     The SR_ subscriptions
        /// </summary>
        private static readonly CallSpec sr_Subscriptions = new CallSpec("_apis/hooks/subscriptions/{subscriptionId}");

        /// <summary>
        ///     The SR_ subscriptions query
        /// </summary>
        private static readonly CallSpec sr_SubscriptionsQuery = new CallSpec("_apis/hooks/subscriptionsQuery");

        /// <summary>
        ///     The SR_ test notifications
        /// </summary>
        private static readonly CallSpec sr_TestNotifications = new CallSpec("_apis/hooks/testNotifications/{notificationId}");
    }
}