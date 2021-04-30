using System;
using Cysharp.Threading.Tasks;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Plugins.UnityAtomsMonoBehaviourUtils {
	public class Timer : MonoBehaviour {
		[Header("References")]
		[SerializeField]
		private IntReference timeLeftRef;

		[Header("Events")]
		[SerializeField]
		private UnityEvent onTimerFinished;

		public async void HandleTimerAsync() {
			do {
				try {
					await UniTask.Delay(TimeSpan.FromSeconds(1)).WithCancellation(this.GetCancellationTokenOnDestroy());
					timeLeftRef.Value--;
				}
				catch (Exception) {
					break;
				}
			} while (timeLeftRef >= 0);

			if (timeLeftRef < 0) {
				onTimerFinished?.Invoke();
			}
		}
	}
}