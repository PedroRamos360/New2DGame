using UnityEngine;
using System.Collections;
using System.Security.Cryptography;

namespace Pathfinding {
	/// <summary>
	/// Sets the destination of an AI to the position of a specified object.
	/// This component should be attached to a GameObject together with a movement script such as AIPath, RichAI or AILerp.
	/// This component will then make the AI move towards the <see cref="target"/> set on this component.
	///
	/// See: <see cref="Pathfinding.IAstarAI.destination"/>
	///
	/// [Open online documentation to see images]
	/// </summary>
	[UniqueComponent(tag = "ai.destination")]
	[HelpURL("http://arongranberg.com/astar/docs/class_pathfinding_1_1_a_i_destination_setter.php")]
	public class AIDestinationSetter : VersionedMonoBehaviour {
		/// <summary>The object that the AI should move to</summary>
		public Transform target;
		IAstarAI ai;
		private GameObject player1;
		private GameObject player2;
		private float differenceToP1;
		private float differenceToP2;

		private void Start() {
			player1 = GameObject.FindGameObjectWithTag("Player1");
			player2 = GameObject.FindGameObjectWithTag("Player2");
		}

		void OnEnable () {
			ai = GetComponent<IAstarAI>();
			// Update the destination right before searching for a path as well.
			// This is enough in theory, but this script will also update the destination every
			// frame as the destination is used for debugging and may be used for other things by other
			// scripts as well. So it makes sense that it is up to date every frame.
			if (ai != null) ai.onSearchPath += Update;
		}

		void OnDisable () {
			if (ai != null) ai.onSearchPath -= Update;
		}

		/// <summary>Updates the AI's destination every frame</summary>
		void Update () {
			if (player1 && player2) {
				differenceToP1 = System.Math.Abs(gameObject.transform.position.x - player1.transform.position.x +
					gameObject.transform.position.y - player1.transform.position.y);

				differenceToP2 = System.Math.Abs(gameObject.transform.position.x - player2.transform.position.x +
					gameObject.transform.position.y - player2.transform.position.y);

				if (differenceToP1 < differenceToP2) {
					target = player1.transform;
				} else {
					target = player2.transform;
				}
			}

			if (target != null && ai != null) ai.destination = target.position;
		}
	}
}
