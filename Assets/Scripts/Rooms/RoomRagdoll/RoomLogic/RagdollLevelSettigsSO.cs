using AYellowpaper.SerializedCollections;
using System.Collections.Generic;
using UnityEngine;

namespace Portfolio.RoomRagdoll
{
    [CreateAssetMenu(fileName = "RagdollRoomSettings", menuName = "ScriptableObject/Rooms/RagdollRoom/Settings")]
    public class RagdollLevelSettigsSO: ScriptableObject
    {
        [SerializeField]
        private SerializedDictionary<RagdollColor, Vector3> _levelHolesSettings;
        [SerializeField]
        private SerializedDictionary<RagdollColor, Vector3> _levelDollsSettings;

        public Dictionary<RagdollColor, Vector3> HolesPositions
        { 
            get => new Dictionary<RagdollColor, Vector3>(_levelHolesSettings); 
        }
        public Dictionary<RagdollColor, Vector3> DollsPositions
        {
            get => new Dictionary<RagdollColor, Vector3>(_levelDollsSettings);
        }
    }
}

