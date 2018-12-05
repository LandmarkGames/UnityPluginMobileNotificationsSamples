using TMPro;
using UnityEngine;

namespace NotificationSamples.Demo
{
	public class PendingNotificationItem : MonoBehaviour
	{
		[SerializeField]
		protected TextMeshProUGUI idLabel;
		[SerializeField]
		protected TextMeshProUGUI titleLabel;
		[SerializeField]
		protected TextMeshProUGUI timeLabel;

		// Reference to pending notification
		private NotificationConsole console;
		private PendingNotification notification;

		/// <summary>
		/// Show for a given pending notification.
		/// </summary>
		public void Show(PendingNotification notificationToDisplay, NotificationConsole containingConsole)
		{
			notification = notificationToDisplay;
			console = containingConsole;

			if (idLabel != null)
			{
				idLabel.text = notificationToDisplay.Id.ToString();
			}

			if (titleLabel != null)
			{
				titleLabel.text = notificationToDisplay.Title;
			}
			
			if (timeLabel != null)
			{
				timeLabel.text = notificationToDisplay.NotificationTime.ToString("yy-MM-dd HH:mm:ss");
			}
		}

		/// <summary>
		/// Cancel this item
		/// </summary>
		public void Cancel()
		{
			console.CancelPendingNotificationItem(notification);
		}
	}
}