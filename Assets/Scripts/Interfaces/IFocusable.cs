using UnityEngine;

namespace Portfolio.Interfaces
{
    public interface IFocusable
    {
        public string FocusInfo { get; }
        public void Focus();
        public void UnFocus();
    }
}

