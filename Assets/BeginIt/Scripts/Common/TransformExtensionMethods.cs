using UnityEngine;

namespace BeginIt {
    public static class TransformExtensionMethods {

        public static Vector2 GetLocalPosition(this Transform transform) {
            return new Vector2(transform.localPosition.x, transform.localPosition.y);
        }

        public static Vector2 GetPosition(this Transform transform) {
            return new Vector2(transform.position.x, transform.position.y);
        }

        public static void SetLocalPositioinX(this Transform transform, float x) {
            transform.localPosition = new Vector3(x, transform.localPosition.y, transform.localPosition.z);
        }

        public static void SetLocalPositioinY(this Transform transform, float y) {
            transform.localPosition = new Vector3(transform.localPosition.x, y, transform.localPosition.z);
        }

        public static void SetLocalPositioinZ(this Transform transform, float z) {
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, z);
        }

        public static void SetLocalPositioin(this Transform transform, float x, float y) {
            transform.localPosition = new Vector3(x, y, transform.localPosition.z);
        }

        public static void SetLocalPositioin(this Transform transform, Vector2 localPosition) {
            transform.localPosition = new Vector3(localPosition.x, localPosition.y, transform.localPosition.z);
        }

        public static void SetPositioinX(this Transform transform, float x) {
            transform.position = new Vector3(x, transform.position.y, transform.position.z);
        }

        public static void SetPositioinY(this Transform transform, float y) {
            transform.position = new Vector3(transform.position.x, y, transform.position.z);
        }

        public static void SetPositioinZ(this Transform transform, float z) {
            transform.position = new Vector3(transform.position.x, transform.position.y, z);
        }

        public static void SetPositioin(this Transform transform, float x, float y) {
            transform.position = new Vector3(x, y, transform.localPosition.z);
        }

        public static void SetPositioin(this Transform transform, Vector2 position) {
            transform.position = new Vector3(position.x, position.y, transform.position.z);
        }

        public static void TranslateX(this Transform transform, float x) {
            transform.Translate(x, 0.0f, 0.0f);
        }

        public static void TranslateY(this Transform transform, float y) {
            transform.Translate(0.0f, y, 0.0f);
        }

        public static void TranslateZ(this Transform transform, float z) {
            transform.Translate(0.0f, 0.0f, z);
        }

        public static void Translate(this Transform transform, float x, float y) {
            transform.Translate(x, y, 0.0f);
        }

        public static void Translate(this Transform transform, Vector2 translation) {
            transform.Translate(translation.x, translation.y, 0.0f);
        }

        /// <summary>
        /// Get localEulerAngles as Vector2.
        /// </summary>
        public static Vector2 GetLocalRotation(this Transform transform) {
            return new Vector2(transform.localEulerAngles.x, transform.localEulerAngles.y);
        }

        /// <summary>
        /// Get eulerAngles as Vector2.
        /// </summary>
        public static Vector2 GetRotation(this Transform transform) {
            return new Vector2(transform.eulerAngles.x, transform.eulerAngles.y);
        }

        /// <summary>
        /// Set localEulerAngles by Vector2.
        /// </summary>
        public static void SetLocalRotation(this Transform transform, float x, float y) {
            transform.localEulerAngles = new Vector3(x, y, transform.localEulerAngles.z);
        }

        /// <summary>
        /// Set localEulerAngles by Vector2.
        /// </summary>
        public static void SetLocalRotation(this Transform transform, Vector2 localRotation) {
            transform.localEulerAngles = new Vector3(localRotation.x, localRotation.y, transform.localEulerAngles.z);
        }

        /// <summary>
        /// Set localEulerAngles x.
        /// </summary>
        public static void SetLocalRotationX(this Transform transform, float x) {
            transform.localEulerAngles = new Vector3(x, transform.localEulerAngles.y, transform.localEulerAngles.z);
        }

        /// <summary>
        /// Set localEulerAngles y.
        /// </summary>
        public static void SetLocalRotationY(this Transform transform, float y) {
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, y, transform.localEulerAngles.z);
        }

        /// <summary>
        /// Set localEulerAngles z.
        /// </summary>
        public static void SetLocalRotationZ(this Transform transform, float z) {
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, z);
        }

        /// <summary>
        /// Set eulerAngles by x and y.
        /// </summary>
        public static void SetRotation(this Transform transform, float x, float y) {
            transform.eulerAngles = new Vector3(x, y, transform.eulerAngles.z);
        }

        /// <summary>
        /// Set eulerAngles by Vector2.
        /// </summary>
        public static void SetRotation(this Transform transform, Vector2 localRotation) {
            transform.eulerAngles = new Vector3(localRotation.x, localRotation.y, transform.eulerAngles.z);
        }

        /// <summary>
        /// Set eulerAngles x.
        /// </summary>
        public static void SetRotationX(this Transform transform, float x) {
            transform.eulerAngles = new Vector3(x, transform.eulerAngles.y, transform.localEulerAngles.z);
        }

        /// <summary>
        /// Set eulerAngles y.
        /// </summary>
        public static void SetRotationY(this Transform transform, float y) {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, y, transform.localEulerAngles.z);
        }

        /// <summary>
        /// Set eulerAngles z.
        /// </summary>
        public static void SetRotationZ(this Transform transform, float z) {
            transform.eulerAngles = new Vector3(transform.localEulerAngles.x, transform.eulerAngles.y, z);
        }

        public static Vector2 GetLocalScale(this Transform transform) {
            return new Vector2(transform.localScale.x, transform.localScale.y);
        }

        public static void SetLocalScale(this Transform transform, float xy) {
            transform.localScale = new Vector3(xy, xy, transform.localScale.z);
        }

        public static void SetLocalScale(this Transform transform, float x, float y) {
            transform.localScale = new Vector3(x, y, transform.localScale.z);
        }

        public static void SetLocalScale(this Transform transform, Vector2 localScale) {
            transform.localScale = new Vector3(localScale.x, localScale.y, transform.localScale.z);
        }

        public static void SetLocalScaleX(this Transform transform, float x) {
            transform.localScale = new Vector3(x, transform.localScale.y, transform.localScale.z);
        }

        public static void SetLocalScaleY(this Transform transform, float y) {
            transform.localScale = new Vector3(transform.localScale.x, y, transform.localScale.z);
        }

        public static void Reset(this Transform transform) {
            transform.position = Vector3.zero;
            transform.localRotation = Quaternion.identity;
            transform.localScale = Vector3.one;
        }
    }
}