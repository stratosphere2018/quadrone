using UnityEngine;

namespace BeginIt {
    public static class ObjectEx {

        public static T Instantiate<T>(Object original, Vector3 position) where T : Object {
            return Object.Instantiate(original as T, position, Quaternion.identity);
        }

        public static T Instantiate<T>(Object original, Vector3 position, Transform parent) where T : Object {
            return Object.Instantiate(original as T, parent.position + position, Quaternion.identity, parent);
        }
    }
}