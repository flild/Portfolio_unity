using System;
using System.Collections.Generic;
using UnityEngine;

namespace Portfolio.RoomRagdoll
{
    public class TargetHitTracker
    {
        private Dictionary<RagdollColor, TargetTrigger> triggersMap;
        private Dictionary<RagdollColor, bool> _markedColors = new();

        public event Action AllTargetHitted;
        public TargetHitTracker(Dictionary<RagdollColor, TargetTrigger> triggers)
        {
            triggersMap = triggers;
            foreach (var triger in triggersMap)
            {
                _markedColors.Add(triger.Key, false);
                triger.Value.dollDropedInTargetEvent += OnDollDropInTrigger;
            }
        }
        public void RestartLevel()
        {
            ClearTargetsMark();
        }
        private void ClearTargetsMark()
        {
            foreach (RagdollColor color in Enum.GetValues(typeof(RagdollColor)))
            {
                _markedColors[color] = false;
            }
        }
        private void OnDollDropInTrigger(RagdollColor targetColor)
        {
            _markedColors[targetColor] = true;
            CheckAllColorOnMark();
        }

        private void CheckAllColorOnMark()
        {
            foreach (var color in _markedColors)
            {
                if(!_markedColors[color.Key])
                {
                    return;
                }
            }
            ClearTargetsMark();
            AllTargetHitted?.Invoke();

        }
    }
}
