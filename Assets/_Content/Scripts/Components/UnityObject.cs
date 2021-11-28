using System;

namespace Game.Ecs.Components
{
    [Serializable]
    struct UnityObject<T> where T : UnityEngine.Object
    {
        public T Value;
    }
}
