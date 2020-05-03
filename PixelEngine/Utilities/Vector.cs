using System;
using System.Collections.Generic;
using static PixelEngine.Utilities.Mathf;

namespace PixelEngine.Utilities {
	#region Mathf
	/// <summary> Like UnityEngine.Mathf, Wrap <see cref="System.Math"/> functions to deal with float/int, and some custom functions. </summary>
	public struct Mathf {
		/// <summary> PI constant (3.14159274f) </summary>
		public const float PI = 3.14159274f;
		/// <summary> PI constant (2.71828182f) </summary>
		public const float E =  2.71828182f;
		/// <summary> Epsilon constant for normalization (1E-05f) </summary>
		public const float EPSILON = 1E-05f;
		/// <summary> Epsilon constant for sqr comaprisons (1E-15f) </summary>
		public const float SQR_EPSILON = 1E-15f;
		/// <summary> Epsilon constant for equality comparisons (9.99999944E-11f) </summary>
		public const float COMPARE_EPSILON = 9.99999944E-11f;
		/// <summary> Infinity </summary>
		public const float Infinity = float.PositiveInfinity;
		/// <summary> Negative Infinity </summary>
		public const float NegativeInfinity = float.NegativeInfinity;
		/// <summary> Multiplicative constant for Degrees to Radians conversion ((2f * PI) / 360f) </summary>
		public const float Deg2Rad = (2f * PI) / 360f;
		/// <summary> Multiplicative constant for Radians to Degrees conversion (360f / (PI * 2f)) </summary>
		public const float Rad2Deg = 360f / (PI * 2f);
		/// <summary> Float wrapper for <see cref="Math.Sin(double)"/></summary> <param name="f"> Angle in radians </param> <returns> Sin Ratio of angle </returns>
		public static float Sin(float f) { return (float)Math.Sin(f); }
		/// <summary> Float wrapper for <see cref="Math.Cos(double)"/></summary> <param name="f"> Angle in radians </param> <returns> Cos Ratio of angle </returns>
		public static float Cos(float f) { return (float)Math.Cos(f); }
		/// <summary> Float wrapper for <see cref="Math.Tan(double)"/></summary> <param name="f"> Angle in radians </param> <returns> Tan Ratio of angle </returns>
		public static float Tan(float f) { return (float)Math.Tan(f); }
		/// <summary> Float wrapper for <see cref="Math.Asin(double)"/></summary> <param name="f"> Sin Ratio </param> <returns> Angle in radians that produces ratio </returns>
		public static float Asin(float f) { return (float)Math.Asin(f); }
		/// <summary> Float wrapper for <see cref="Math.Acos(double)"/></summary> <param name="f"> Cos Ratio </param> <returns> Angle in radians that produces ratio </returns>
		public static float Acos(float f) { return (float)Math.Acos(f); }
		/// <summary> Float wrapper for <see cref="Math.Atan(double)"/></summary> <param name="f"> Tan Ratio </param> <returns> Angle in radians that produces ratio </returns>
		public static float Atan(float f) { return (float)Math.Atan(f); }
		/// <summary> Float wrapper for <see cref="Math.Atan2(double,double)"/></summary> 
		/// <param name="x"> x part of ratio </param> <param name="y"> y part of ratio </param> 
		/// <returns> Angle in radians that produces given ratio </returns>
		public static float Atan2(float y, float x) { return (float)Math.Atan2(y, x); }
		/// <summary> Float wrapper for <see cref="Math.Sqrt(double)"/></summary> <param name="f"> Number </param> <returns> Square root of number </returns>
		public static float Sqrt(float f) { return (float)Math.Sqrt(f); }
		/// <summary> Float wrapper for <see cref="Math.Abs(double)"/></summary> <param name="f"> Number </param> <returns> Absolute value of number </returns>
		public static float Abs(float f) { return Math.Abs(f); }
		/// <summary> wrapper for <see cref="Math.Abs(int)"/></summary> <param name="f"> Number </param> <returns> Absolute value of number </returns>
		public static int Abs(int f) { return Math.Abs(f); }

		/// <summary> Wrapper for <see cref="Math.Pow(double, double)"/> </summary>
		/// <param name="f"> base to raise </param> <param name="p"> power to raise to </param> <returns> Base raised to given power </returns>
		public static float Pow(float f, float p) { return (float)Math.Pow(f, p); }
		/// <summary> wrapper for <see cref="Math.Exp(double)"/></summary> <param name="power"> power </param> <returns> e raised to power </returns>
		public static float Exp(float power) { return (float)Math.Exp(power); }
		/// <summary> Wrapper for <see cref="Math.Log(double, double)"/></summary> <param name="f"> Number </param> <param name="b"> base</param> <returns> Log_base of number</returns>
		public static float Log(float f, float b) { return (float)Math.Log(f, b); }
		/// <summary> Wrapper for <see cref="Math.Log(double)"/></summary> <param name="f"> Number </param> <returns> Natural log of number </returns>
		public static float Log(float f) { return (float)Math.Log(f); }
		/// <summary> Wrapper for <see cref="Math.Log10(double)"/></summary> <param name="f"> Number </param> <returns> Log10 of number </returns>
		public static float Log10(float f) { return (float)Math.Log10(f); }

		/// <summary> Wrapper for <see cref="Math.Ceiling(double)"/> </summary>
		public static float Ceil(float f) { return (float)Math.Ceiling(f); }
		/// <summary> Wrapper for <see cref="Math.Ceiling(double)"/>, cast to <see cref="int"/>. </summary>
		public static int CeilToInt(float f) { return (int)Math.Ceiling(f); }
		/// <summary> Wrapper for <see cref="Math.Floor(double)"/> </summary>
		public static float Floor(float f) { return (float)Math.Floor(f); }
		/// <summary> Wrapper for <see cref="Math.Floor(double)"/>, cast to <see cref="int"/> </summary>
		public static int FloorToInt(float f) { return (int)Math.Floor(f); }
		/// <summary> Wrapper for <see cref="Math.Round(double)"/> </summary>
		public static float Round(float f) { return (float)Math.Round(f); }
		/// <summary> Wrapper for <see cref="Math.Round(double)"/>, cast to <see cref="int"/> </summary>
		public static int RoundToInt(float f) { return (int)Math.Round(f); }

		/// <summary> Pick the minimum of two <see cref="float"/> values</summary>
		public static float Min(float a, float b) { return a < b ? a : b; }
		/// <summary> Pick the minimum of three <see cref="float"/> values</summary>
		public static float Min(float a, float b, float c) { return a < b ? (a < c ? a : c) : (b < c ? b : c); }
		/// <summary> Pick the maximum of two <see cref="float"/> values</summary>
		public static float Max(float a, float b) { return a > b ? a : b; }
		/// <summary> Pick the maximum of three <see cref="float"/> values</summary>
		public static float Max(float a, float b, float c) { return a > b ? (a > c ? a : c) : (b > c ? b : c); }
		/// <summary> Pick the minimum of two <see cref="int"/> values</summary>
		public static int Min(int a, int b) { return a < b ? a : b; }
		/// <summary> Pick the minimum of three <see cref="int"/> values</summary>
		public static int Min(int a, int b, int c) { return a < b ? (a < c ? a : c) : (b < c ? b : c); }
		/// <summary> Pick the maximum of two <see cref="int"/> values</summary>
		public static int Max(int a, int b) { return a > b ? a : b; }
		/// <summary> Pick the maximum of three <see cref="int"/> values</summary>
		public static int Max(int a, int b, int c) { return a > b ? (a > c ? a : c) : (b > c ? b : c); }

		/// <summary> Repeat a number <paramref name="f"/> over range [0, <paramref name="length"/>). </summary>
		public static float Repeat(float f, float length) { return Clamp(f - Floor(f / length) * length, 0, length); }
		/// <summary> Make a number <paramref name="f"/> go back and forth between range [0, <paramref name="length"/>). </summary>
		public static float PingPong(float f, float length) { f = Repeat(f, length * 2f); return length - Abs(f - length); }

		/// <summary> Gets the sign of the number <paramref name="f"/> as -1 if negative or +1 if positive/zero </summary>
		public static float Sign(float f) { return (f < 0) ? -1f : 1f; }
		/// <summary> Clamp a number <paramref name="f"/> between [0, 1] </summary>
		public static float Clamp01(float f) { return f < 0 ? 0 : f > 1 ? 1 : f; }
		/// <summary> Clamp a number <paramref name="f"/> between [<paramref name="min"/>, <paramref name="max"/>] </summary>
		public static float Clamp(float f, float min, float max) { return f < min ? min : f > max ? max : f; }
		/// <summary> Clamp a number <paramref name="f"/> between [<paramref name="min"/>, <paramref name="max"/>] </summary>
		public static int Clamp(int f, int min, int max) { return f < min ? min : f > max ? max : f; }
		/// <summary> Get the real difference between two angles (in degrees) </summary>
		public static float DeltaAngle(float current, float target) {
			float angle = Repeat(target - current, 360f);
			if (angle > 180f) { angle -= 360f; }
			return angle;
		}
		// @TODO: Look into the specific value of UnityEngine.Mathf.Epsilon (for COMPARE_EPSILON)
		/// <summary> Check two numbers for aproximate equivelancy. </summary>
		public static bool Approximately(float a, float b) {
			return Abs(b - a) < Max(1E-06f * Max(Abs(a), Abs(b)), COMPARE_EPSILON * 8f);
		}
		/// <summary> Map <paramref name="val"/> from [<paramref name="a"/>, <paramref name="b"/>] space into [<paramref name="x"/>, <paramref name="y"/>] space</summary>
		public static float Map(float a, float b, float val, float x, float y) { return Lerp(x, y, InverseLerp(a, b, val)); }
		/// <summary> Linearly interpolate <paramref name="f"/> between [<paramref name="a"/>, <paramref name="b"/>]. </summary>
		public static float Lerp(float a, float b, float f) { return a + (b - a) * Clamp01(f); }
		/// <summary> Get the proportion <paramref name="value"/> is at between [<paramref name="a"/>, <paramref name="b"/>]. </summary>
		public static float InverseLerp(float a, float b, float value) { return (a != b) ? Clamp01((value - a) / (b - a)) : 0f; }
		/// <summary> Linearly interpolate <paramref name="f"/> between [<paramref name="a"/>, <paramref name="b"/>], without constraint inside [0,1] </summary>
		public static float LerpUnclamped(float a, float b, float f) { return a + (b - a) * f; }
		/// <summary> Smoothly interpolate <paramref name="f"/> between [<paramref name="a"/>, <paramref name="b"/>]. </summary>
		public static float SmoothStep(float a, float b, float f) {
			f = Clamp01(f);
			f = -2f * f * f * f + 3f * f * f;
			return a * f + b * (1f - f);
		}
		/// <summary> Linearly interpolate, as an angle, <paramref name="f"/> between [<paramref name="a"/>, <paramref name="b"/>]. </summary>
		public static float LerpAngle(float a, float b, float f) {
			float angle = Repeat(b - a, 360f);
			if (angle > 180f) { angle -= 360f; }
			return a + angle * Clamp01(f);
		}
		/// <summary> Raw step <paramref name="current"/> towards <paramref name="target"/>, at most changing by <paramref name="maxDelta"/>. </summary>
		public static float MoveTowards(float current, float target, float maxDelta) {
			return (Abs(target - current) <= maxDelta) ? target : (current + Sign(target - current) * maxDelta);
		}
		/// <summary> Raw step, as an angle, <paramref name="current"/> towards <paramref name="target"/>, at most changing by <paramref name="maxDelta"/>. </summary>
		public static float MoveTowardsAngle(float current, float target, float maxDelta) {
			float delta = DeltaAngle(current, target);
			return (-maxDelta < delta && delta < maxDelta) ? target : MoveTowards(current, current + delta, maxDelta);
		}
		/// <summary> Real part of the Gamma function. </summary>
		public static float Gamma(float value, float absmax, float gamma) {
			bool negative = value < 0f;
			float abs = Abs(value);
			if (abs > absmax) { return negative ? -abs : abs; }
			float pow = Pow(abs / absmax, gamma) * absmax;
			return negative ? -pow : pow;
		}
		/// <summary> Smoothly dampen <paramref name="current"/> to <paramref name="target"/>. Uses and updates <paramref name="currentVelocity"/>, and steps over the given <paramref name="deltaTime"/>.
		/// Current will reach the target in approximately <paramref name="smoothTime"/>, unless the <paramref name="maxSpeed"/> is used to clamp changes. </summary>
		/// <param name="current"> Current position </param>
		/// <param name="target"> Target to reach </param>
		/// <param name="currentVelocity"> Current velocity reference. Modified by the function every time it is called. </param>
		/// <param name="smoothTime"> Appxoimately the time to reach the target in seconds. Smaller time reaches the target faster. </param>
		/// <param name="deltaTime"> Time since the last update. </param>
		/// <param name="maxSpeed"> Optionally allows the change speed to be clamped. </param>
		/// <returns> Position after timestep has been applied. </returns>
		public static float Damp(float current, float target, ref float currentVelocity, float smoothTime, float deltaTime, float maxSpeed = Infinity) {
			smoothTime = Max(.0001f, smoothTime);
			float step = 2f / smoothTime;
			float d = step * deltaTime;
			float smoothed = 1f / (1f + d + 0.48f * d * d + 0.235f * d * d * d);

			float desired = target;
			float maxDelta = maxSpeed * smoothTime;
			float diff = Clamp(current - target, -maxDelta, maxDelta);
			target = current - diff;

			float velocityStep = (currentVelocity + step * diff) * deltaTime;
			currentVelocity = (currentVelocity - step * velocityStep) * smoothed;
			float result = target + (diff + velocityStep) * smoothed;
			if (desired - current > 0f == result > desired) {
				result = desired;
				currentVelocity = (result - desired) / deltaTime;
			}
			return result;
		}

		/// <summary> Smoothly dampens the given <paramref name="current"/> angle towards the <paramref name="target"/> angle. 
		/// Internally uses <see cref="Damp(float, float, ref float, float, float, float)"/> with values treated in angle space. </summary>
		/// <param name="current"> Current angle </param>
		/// <param name="target"> Target angle to reach </param>
		/// <param name="currentVelocity"> Current angular velocity reference. Modified by the function every time it is called. </param>
		/// <param name="smoothTime"> Appxoimately the time to reach the target in seconds. Smaller time reaches the target faster. </param>
		/// <param name="deltaTime"> Time since the last update. </param>
		/// <param name="maxSpeed"> Optionally allows the change speed to be clamped. </param>
		/// <returns> Angle after timestep has been applied. </returns>
		public static float DampAngle(float current, float target, ref float currentVelocity, float smoothTime, float deltaTime, float maxSpeed = Infinity) {
			target = current + DeltaAngle(current, target);
			return Damp(current, target, ref currentVelocity, smoothTime, deltaTime, maxSpeed);
		}
		/// <summary> Apply a spring function to the <paramref name="value"/>, stabilizing at <paramref name="target"/>. 
		/// Uses the given <paramref name="velocity"/>, and applied over the given <paramref name="deltaTime"/>. 
		/// optionally a speciifc <paramref name="strength"/> and <paramref name="dampening"/> value can be set. </summary>
		/// <param name="value"> Current value </param>
		/// <param name="target"> Stability target </param>
		/// <param name="velocity"> Current motion </param>
		/// <param name="deltaTime"> Last time step </param>
		/// <param name="strength"> Spring force multiplier </param>
		/// <param name="dampening"> Spring force removal base power (out of 10000) </param>
		/// <returns> Updated value after timestep has been applied. </returns>
		public static float Spring(float value, float target, ref float velocity, float deltaTime, float strength = 100, float dampening = 1) {
			velocity += (target - value) * strength * deltaTime;
			velocity *= Pow(dampening * .0001f, deltaTime);
			value += velocity * deltaTime;
			return value;
		}
	}
	#endregion Mathf
	//////////////////////////////////////////////////////////////////////////////////////////////////////////
	/////////////////////////////////////////////////////////////////////////////////////////////////////////
	////////////////////////////////////////////////////////////////////////////////////////////////////////
	#region Vector2
	/// <summary> Surrogate Vector2 class, similar to UnityEngine.Vector2. Stores two <see cref="float"/> components, and provides some math functions. </summary>
	[System.Serializable]
	public struct Vector2 {
		/// <summary> Zero <see cref="Vector2"/> (0, 0) </summary>
		public static Vector2 zero { get { return new Vector2(0, 0); } }
		/// <summary> One unit <see cref="Vector2"/> (1, 1) </summary>
		public static Vector2 one { get { return new Vector2(1, 1); } }
		/// <summary> Up unit <see cref="Vector2"/> (0, 1) </summary>
		public static Vector2 up { get { return new Vector2(0, 1); } }
		/// <summary> Down unit <see cref="Vector2"/> (0, -1) </summary>
		public static Vector2 down { get { return new Vector2(0, -1); } }
		/// <summary> Left unit <see cref="Vector2"/> (-1, 0) </summary>
		public static Vector2 left { get { return new Vector2(-1, 0); } }
		/// <summary> Right unit <see cref="Vector2"/> (1, 0) </summary>
		public static Vector2 right { get { return new Vector2(1, 0); } }
		/// <summary> Negative Infinity Unit <see cref="Vector2"/> (-inf, -inf) </summary>
		public static Vector2 negativeInfinity { get { return new Vector2(float.NegativeInfinity, float.NegativeInfinity); } }
		/// <summary> Positive Infinity Unit <see cref="Vector2"/> (+inf, +inf) </summary>
		public static Vector2 positiveInfinity { get { return new Vector2(float.PositiveInfinity, float.PositiveInfinity); } }

		/// <summary> Vector component  </summary>
		public float x, y;
		/// <summary> RGBA Component </summary>
		public float r { get { return x; } set { x = value; } }
		/// <summary> RGBA Component </summary>
		public float g { get { return y; } set { y = value; } }

		/// <summary> Create a <see cref="Vector2"/> with the given components  </summary>
		public Vector2(float x, float y) { this.x = x; this.y = y; }

		/// <summary> <see cref="Vector2"/> Swizzle </summary>
		public Vector2 xx { get { return new Vector2(x,x); } }
		/// <summary> <see cref="Vector2"/> Swizzle </summary>
		public Vector2 xy { get { return new Vector2(x,y); } set { x = value.x; y = value.y; } }
		/// <summary> <see cref="Vector2"/> Swizzle </summary>
		public Vector2 yx { get { return new Vector2(y,x); } set { y = value.x; x = value.y; } }
		/// <summary> <see cref="Vector2"/> Swizzle </summary>
		public Vector2 yy { get { return new Vector2(y,y); } }

		/// <summary> <see cref="Vector2"/> length by distance formula (Sqrt(x*x + y*y)) </summary>
		public float magnitude { get { return Mathf.Sqrt(x * x + y * y); } }
		/// <summary> <see cref="Vector2"/> squared length, partial distance formula (x*x + y*y), faster for length comparison than using <see cref="Sqrt(float)"/> </summary>
		public float sqrMagnitude { get { return (x * x) + (y * y); } }
		/// <summary> Create a <see cref="Vector2"/> with length 1 in the same direction as this vector, or zero if the vector is really short. </summary>
		public Vector2 normalized { get { float m = magnitude; if (m > EPSILON) { return this / m; } return zero; } }
		/// <summary> Index-wise access to <see cref="Vector2"/> components. Index must be in range [0, 1] </summary>
		public float this[int i] {
			get { if (i == 0) { return x; } if (i == 1) { return y; } throw new IndexOutOfRangeException($"Vector2 has length=2, {i} is out of range."); }
			set { if (i == 0) { x = value; } if (i == 1) { y = value; } throw new IndexOutOfRangeException($"Vector2 has length=2, {i} is out of range."); }
		}

		/// <inheritdoc />
		public override bool Equals(object other) { return other is Vector2 && Equals((Vector2)other); }
		/// <summary> Compare <see cref="Vector2"/> by component values. </summary>
		public bool Equals(Vector2 other) { return x.Equals(other.x) && y.Equals(other.y); }
		/// <inheritdoc />
		public override int GetHashCode() { return x.GetHashCode() ^ y.GetHashCode() << 2; }
		/// <inheritdoc />
		public override string ToString() { return $"({x:F2}, {y:F2})"; }

		/// <summary> Normalizes this <see cref="Vector2"/> in-place. Modifies the x/y in the memory location it is called on. </summary>
		public void Normalize() { float m = magnitude; if (m > EPSILON) { this /= m; } else { this = zero; } }
		/// <summary> Sets the x/y component of the <see cref="Vector2"/> in-place. Modifies the x/y in the memory location it is called on. </summary>
		public void Set(float x, float y) { this.x = x; this.y = y; }
		/// <summary> Scales this <see cref="Vector2"/> in-place to be (<paramref name="a"/>*<see cref="x"/>, <paramref name="b"/>*<see cref="y"/>). Modifies the x/y in the memory location it is called on. </summary>
		public void Scale(float a, float b) { x *= a; y *= b; }
		/// <summary> Scales this <see cref="Vector2"/> in-place by another vector <paramref name="s"/>, component wise. Modifies the x/y in the memory location it is called on. </summary>
		public void Scale(Vector2 s) { x *= s.x; y *= s.y; }
		/// <summary> Clamps this <see cref="Vector2"/> in-place. Modifies the x/y in the memory location it is called on. </summary>
		public void Clamp(Vector2 min, Vector2 max) {
			x = Mathf.Clamp(x, min.x, max.x);
			y = Mathf.Clamp(y, min.y, max.y);
		}

		/// <summary> <see cref="Mathf.FloorToInt(float)"/>'s each component in this <see cref="Vector2"/> to produce a <see cref="Vector2Int"/></summary>
		public Vector2Int FloorToInt() { return new Vector2Int(Mathf.FloorToInt(x), Mathf.FloorToInt(y)); }
		/// <summary> <see cref="Mathf.CeilToInt(float)"/>'s each component in this <see cref="Vector2"/> to produce a <see cref="Vector2Int"/></summary>
		public Vector2Int CeilToInt() { return new Vector2Int(Mathf.CeilToInt(x), Mathf.CeilToInt(y)); }
		/// <summary> <see cref="Mathf.RoundToInt(float)"/>'s each component in this <see cref="Vector2"/> to produce a <see cref="Vector2Int"/></summary>
		public Vector2Int RoundToInt() { return new Vector2Int(Mathf.RoundToInt(x), Mathf.RoundToInt(y)); }

		/// <summary> Get component-wise absolute value of this <see cref="Vector2"/>. </summary>
		public Vector2 Abs() { return new Vector2(Mathf.Abs(x), Mathf.Abs(y)); }

		/// <summary> Get component-wise absolute value of given <see cref="Vector2"/>. </summary>
		public static Vector2 Abs(Vector2 v) { return new Vector2(Mathf.Abs(v.x), Mathf.Abs(v.y)); }

		/// <summary> Calculate dot product between <see cref="Vector2"/>s <paramref name="a"/> and <paramref name="b"/></summary>
		public static float Dot(Vector2 a, Vector2 b) { return a.x * b.x + a.y * b.y; }
		/// <summary> Componentwise Min between <see cref="Vector2"/>s <paramref name="a"/> and <paramref name="b"/></summary>
		public static Vector2 Min(Vector2 a, Vector2 b) { return new Vector2(Mathf.Min(a.x, b.x), Mathf.Min(a.y, b.y)); }
		/// <summary> Componentwise Max between <see cref="Vector2"/>s <paramref name="a"/> and <paramref name="b"/></summary>
		public static Vector2 Max(Vector2 a, Vector2 b) { return new Vector2(Mathf.Max(a.x, b.x), Mathf.Max(a.y, b.y)); }

		/// <summary> Linearly interpolate between <see cref="Vector2"/>s <paramref name="a"/> and <paramref name="b"/> by proportion <paramref name="f"/>. </summary>
		public static Vector2 Lerp(Vector2 a, Vector2 b, float f) { f = Clamp01(f); return new Vector2(a.x + (b.x - a.x) * f, a.y + (b.y - a.y) * f); }
		/// <summary> Linearly interpolate between <see cref="Vector2"/>s <paramref name="a"/> and <paramref name="b"/> by proportion <paramref name="f"/>, without a <see cref="Mathf.Clamp01(float)"/>. </summary>
		public static Vector2 LerpUnclamped(Vector2 a, Vector2 b, float f) { return new Vector2(a.x + (b.x - a.x) * f, a.y + (b.y - a.y) * f); }
		/// <summary> Steps <paramref name="current"/> <see cref="Vector2"/> towards <paramref name="target"/>, at most moving <paramref name="maxDistanceDelta"/>. </summary>
		/// <param name="current"> Current <see cref="Vector2"/> location </param>
		/// <param name="target"> Target <see cref="Vector2"/> location </param>
		/// <param name="maxDistanceDelta"> Maximum distance to move </param>
		/// <returns> <paramref name="current"/> stepped towards <paramref name="target"/>, at most by <paramref name="maxDistanceDelta"/> units. </returns>
		public static Vector2 MoveTowards(Vector2 current, Vector2 target, float maxDistanceDelta) {
			Vector2 a = target - current;
			float m = a.magnitude;
			return (m < maxDistanceDelta || m == 0f) ? target : (current + a / m * maxDistanceDelta);
		}
		/// <summary> Scales one <see cref="Vector2"/> <paramref name="a"/>componentwise by another <paramref name="b"/>. </summary>
		public static Vector2 Scale(Vector2 a, Vector2 b) { return new Vector2(a.x * b.x, a.y * b.y); }
		/// <summary> Clamps the length of the <paramref name="vector"/> so it is not longer than <paramref name="maxLength"/>. </summary>
		public static Vector2 ClampMagnitude(Vector2 vector, float maxLength) {
			return (vector.sqrMagnitude > maxLength * maxLength) ? vector.normalized * maxLength : vector;
		}
		/// <summary> Reflect a <paramref name="dir"/>ection <see cref="Vector2"/> about a surface <paramref name="normal"/>. </summary>
		public static Vector2 Reflect(Vector2 dir, Vector2 normal) { return -2f * Dot(normal, dir) * normal + dir; }
		/// <summary> Project a <paramref name="dir"/>ection <see cref="Vector2"/> along another direction, <paramref name="normal"/>. </summary>
		public static Vector2 Project(Vector2 dir, Vector2 normal) {
			float len = Dot(normal, normal);
			return (len < SQR_EPSILON) ? zero : normal * Dot(dir, normal) / len;
		}
		/// <summary> Create a <see cref="Vector2"/> that is perpindicular to the given <paramref name="dir"/>ection. </summary>
		public static Vector2 Perpendicular(Vector2 dir) { return new Vector2(-dir.y, dir.x); }

		/// <summary> Calculate distance between <see cref="Vector2"/>s <paramref name="a"/> and <paramref name="b"/>. </summary>
		public static float Distance(Vector2 a, Vector2 b) { return (a - b).magnitude; }
		/// <summary> Calculate absolute angle between <see cref="Vector2"/>s <paramref name="from"/> and <paramref name="to"/> when placed at origin. </summary>
		public static float Angle(Vector2 from, Vector2 to) {
			float e = Sqrt(from.sqrMagnitude * to.sqrMagnitude);
			if (e < SQR_EPSILON) { return 0; }
			float f = Mathf.Clamp(Dot(from, to) / e, -1f, 1f);
			return Acos(f) * Rad2Deg;
		}
		/// <summary> Calculate signed angle between two <see cref="Vector2"/>s <paramref name="from"/> and <paramref name="to"/> when placed at origin. </summary>
		public static float SignedAngle(Vector2 from, Vector2 to) {
			float angle = Angle(from, to);
			float sign = Sign(from.x * to.y - from.y * to.x);
			return sign * angle;
		}

		/// <summary> Negate both components of the given <see cref="Vector2"/>. </summary>
		public static Vector2 operator -(Vector2 a) { return new Vector2(-a.x, -a.y); }
		/// <summary> Add <see cref="Vector2"/>s <paramref name="a"/> and <paramref name="b"/>. </summary>
		public static Vector2 operator +(Vector2 a, Vector2 b) { return new Vector2(a.x + b.x, a.y + b.y); }
		/// <summary> Subtract <see cref="Vector2"/> <paramref name="b"/> from <paramref name="a"/>. </summary>
		public static Vector2 operator -(Vector2 a, Vector2 b) { return new Vector2(a.x - b.x, a.y - b.y); }
		/// <summary> Multiply <see cref="Vector2"/>s <paramref name="a"/> and <paramref name="b"/>. </summary>
		public static Vector2 operator *(Vector2 a, Vector2 b) { return new Vector2(a.x * b.x, a.y * b.y); }
		/// <summary> Divide <see cref="Vector2"/> <paramref name="a"/> by <paramref name="b"/>. </summary>
		public static Vector2 operator /(Vector2 a, Vector2 b) { return new Vector2(a.x / b.x, a.y / b.y); }
		/// <summary> Multiply <see cref="Vector2"/> <paramref name="a"/> by float <paramref name="f"/>. </summary>
		public static Vector2 operator *(Vector2 a, float f) { return new Vector2(a.x * f, a.y * f); }
		/// <summary> Multiply <see cref="Vector2"/> <paramref name="a"/> by float <paramref name="f"/>. </summary>
		public static Vector2 operator *(float f, Vector2 a) { return new Vector2(a.x * f, a.y * f); }
		/// <summary> Divide <see cref="Vector2"/> <paramref name="a"/> by <paramref name="f"/>. </summary>
		public static Vector2 operator /(Vector2 a, float f) { return new Vector2(a.x / f, a.y / f); }
		/// <summary> Inverse divide <see cref="Vector2"/> <paramref name="a"/> by <paramref name="f"/>. </summary>
		public static Vector2 operator /(float f, Vector2 a) { return new Vector2(f / a.x, f / a.y); }
		/// <summary> Compare <see cref="Vector2"/>s <paramref name="a"/> and <paramref name="b"/>, by approximate equality, if their <see cref="sqrMagnitude"/> of difference is within <see cref="COMPARE_EPSILON"/>. </summary>
		public static bool operator ==(Vector2 a, Vector2 b) { return (a - b).sqrMagnitude < COMPARE_EPSILON; }
		/// <summary> Inversion of comparison of <see cref="Vector2"/>s <paramref name="a"/> and <paramref name="b"/>, by approximate equality, if their <see cref="sqrMagnitude"/> of difference is within <see cref="COMPARE_EPSILON"/>. </summary>
		public static bool operator !=(Vector2 a, Vector2 b) { return !(a == b); }

		/// <summary> Automatic coercion of <see cref="Vector3"/> to <see cref="Vector2"/> </summary>
		public static implicit operator Vector2(Vector3 v) { return new Vector2(v.x, v.y); }
		/// <summary> Automatic coercion of <see cref="Vector2"/> to <see cref="Vector3"/> </summary>
		public static implicit operator Vector3(Vector2 v) { return new Vector3(v.x, v.y, 0f); }
	}
	#endregion
	//////////////////////////////////////////////////////////////////////////////////////////////////////////
	/////////////////////////////////////////////////////////////////////////////////////////////////////////
	////////////////////////////////////////////////////////////////////////////////////////////////////////
	#region Vector2Int
	/// <summary> Surrogate class, similar to UnityEngine.Vector2Int. Stores two <see cref="int"/> components, and provides some math functions. </summary>
	[System.Serializable]
	public struct Vector2Int : IEquatable<Vector2Int> {
		/// <summary> Zero <see cref="Vector2Int"/>, (0, 0). </summary>
		public static Vector2Int zero { get { return new Vector2Int(0, 0); } }
		/// <summary> One unit <see cref="Vector2Int"/>, (1, 1). </summary>
		public static Vector2Int one { get { return new Vector2Int(1, 1); } }
		/// <summary> Up unit <see cref="Vector2Int"/>, (0, 1). </summary>
		public static Vector2Int up { get { return new Vector2Int(0, 1); } }
		/// <summary> Down unit <see cref="Vector2Int"/>, (0, -1). </summary>
		public static Vector2Int down { get { return new Vector2Int(0, -1); } }
		/// <summary> Left unit <see cref="Vector2Int"/>, (-1, 0). </summary>
		public static Vector2Int left { get { return new Vector2Int(-1, 0); } }
		/// <summary> Right unit <see cref="Vector2Int"/>, (1, 0). </summary>
		public static Vector2Int right { get { return new Vector2Int(1, 0); } }

		/// <summary> Vector component </summary>
		public int x, y;
		/// <summary> Construct a <see cref="Vector2Int"/> with the given components. </summary>
		public Vector2Int(int x, int y) { this.x = x; this.y = y; }

		/// <summary> Index-wise access to <see cref="Vector2Int"/> components Index Must be in range [0, 1] </summary>
		public int this[int i] {
			get { if (i == 0) { return x; } if (i == 1) { return y; } throw new IndexOutOfRangeException($"Vector2Int has length=2, {i} is out of range."); }
			set { if (i == 0) { x = value; } if (i == 1) { y = value; } throw new IndexOutOfRangeException($"Vector2Int has length=2, {i} is out of range."); }
		}

		/// <inheritdoc />
		public override bool Equals(object other) { return other is Vector2Int && Equals((Vector2Int)other); }
		/// <summary> Compare by exact component values </summary>
		public bool Equals(Vector2Int other) { return x.Equals(other.x) && y.Equals(other.y); }
		/// <inheritdoc />
		public override int GetHashCode() { return x.GetHashCode() ^ y.GetHashCode() << 2; }
		/// <inheritdoc />
		public override string ToString() { return $"({x}, {y})"; }

		/// <summary> <see cref="Vector2Int"/> Swizzle </summary>
		public Vector2Int xx { get { return new Vector2Int(x, x); } }
		/// <summary> <see cref="Vector2Int"/> Swizzle </summary>
		public Vector2Int xy { get { return new Vector2Int(x, y); } set { x = value.x; y = value.y; } }
		/// <summary> <see cref="Vector2Int"/> Swizzle </summary>
		public Vector2Int yx { get { return new Vector2Int(y, x); } set { y = value.x; x = value.y; } }
		/// <summary> <see cref="Vector2Int"/> Swizzle </summary>
		public Vector2Int yy { get { return new Vector2Int(y, y); } }

		/// <summary> <see cref="Vector2Int"/> length by distance formula (Sqrt(x*x + y*y)) </summary>
		public float magnitude { get { return Sqrt(x * x + y * y); } }
		/// <summary> <see cref="Vector2Int"/> length by partial distance formula (x*x + y*y), faster without the <see cref="Sqrt(float)"/>. </summary>
		public int sqrMagnitude { get { return x * x + y * y; } }

		/// <summary> Sets the x/y component of the vector in-place. Modifies the x/y in the memory location it is called on. </summary>
		public void Set(int a, int b) { x = a; y = b; }
		/// <summary> Scales this <see cref="Vector2Int"/> in-place by another vector <paramref name="scale"/>, component wise. Modifies the x/y in the memory location it is called on. </summary>
		public void Scale(Vector2Int scale) { x *= scale.x; y *= scale.y; }
		/// <summary> Clamp <see cref="Vector2Int"/> in-place between <paramref name="min"/> and <paramref name="max"/>. Modifies the x/y in the memory location it is called on.  </summary>
		public void Clamp(Vector2 min, Vector2 max) {
			x = (int)Mathf.Clamp(x, min.x, max.x);
			y = (int)Mathf.Clamp(y, min.y, max.y);
		}

		/// <summary> Get component-wise absolute value of this <see cref="Vector2Int"/>. </summary>
		public Vector2Int Abs() { return new Vector2Int(Mathf.Abs(x), Mathf.Abs(y)); }

		/// <summary> Get component-wise absolute value of given <see cref="Vector2Int"/>. </summary>
		public static Vector2Int Abs(Vector2Int v) { return new Vector2Int(Mathf.Abs(v.x), Mathf.Abs(v.y)); }

		/// <summary> Component-wise minimum between <paramref name="a"/> and <paramref name="b"/>. </summary>
		public static Vector2Int Min(Vector2Int a, Vector2Int b) { return new Vector2Int(Mathf.Min(a.x, b.x), Mathf.Min(a.y, b.y)); }
		/// <summary> Component-wise maximum between <paramref name="a"/> and <paramref name="b"/>. </summary>
		public static Vector2Int Max(Vector2Int a, Vector2Int b) { return new Vector2Int(Mathf.Max(a.x, b.x), Mathf.Max(a.y, b.y)); }
		/// <summary> Scale <paramref name="a"/> component-wise by <paramref name="b"/>. </summary>
		public static Vector2Int Scale(Vector2Int a, Vector2Int b) { return new Vector2Int(a.x * b.x, a.y * b.y); }
		/// <summary> Get distance between <paramref name="a"/> and <paramref name="b"/>. </summary>
		public static float Distance(Vector2Int a, Vector2Int b) { return (b - a).magnitude; }

		/// <summary> Negate each component of a <see cref="Vector2Int"/> </summary>
		public static Vector2Int operator -(Vector2Int a) { return new Vector2Int(-a.x, -a.y); }
		/// <summary> Add <paramref name="a"/> and <paramref name="b"/> </summary>
		public static Vector2Int operator +(Vector2Int a, Vector2Int b) { return new Vector2Int(a.x + b.x, a.y + b.y); }
		/// <summary> Add <paramref name="b"/> from <paramref name="a"/> </summary>
		public static Vector2Int operator -(Vector2Int a, Vector2Int b) { return new Vector2Int(a.x - b.x, a.y - b.y); }
		/// <summary> Multiply <paramref name="a"/> and <paramref name="b"/> </summary>
		public static Vector2Int operator *(Vector2Int a, Vector2Int b) { return new Vector2Int(a.x * b.x, a.y * b.y); }
		/// <summary> Divide<paramref name="a"/> by <paramref name="b"/> </summary>
		public static Vector2Int operator /(Vector2Int a, Vector2Int b) { return new Vector2Int(a.x / b.x, a.y / b.y); }
		/// <summary> Multiply <paramref name="a"/> and <paramref name="i"/> </summary>
		public static Vector2Int operator *(Vector2Int a, int i) { return new Vector2Int(a.x * i, a.y * i); }
		/// <summary> Multiply <paramref name="a"/> and <paramref name="i"/> </summary>
		public static Vector2Int operator *(int i, Vector2Int a) { return new Vector2Int(a.x * i, a.y * i); }
		/// <summary> Divide<paramref name="a"/> by <paramref name="i"/> </summary>
		public static Vector2Int operator /(Vector2Int a, int i) { return new Vector2Int(a.x / i, a.y / i); }
		/// <summary> Inverse divide<paramref name="a"/> by <paramref name="i"/> </summary>
		public static Vector2Int operator /(int i, Vector2Int a) { return new Vector2Int(i / a.x, i / a.y); }
		/// <summary> Compare components of <paramref name="a"/> and <paramref name="b"/> </summary>
		public static bool operator ==(Vector2Int a, Vector2Int b) { return a.x == b.x && a.y == b.y; }
		/// <summary> Inverse compare components of <paramref name="a"/> and <paramref name="b"/> </summary>
		public static bool operator !=(Vector2Int a, Vector2Int b) { return !(a == b); }

		/// <summary> Automatically promote a <see cref="Vector2Int"/> into  a <see cref="Vector2"/> </summary>
		public static implicit operator Vector2(Vector2Int v) { return new Vector2(v.x, v.y); }
		/// <summary> Automatically promote a <see cref="Vector2Int"/> into  a <see cref="Vector3Int"/> </summary>
		public static implicit operator Vector3Int(Vector2Int v) { return new Vector3Int(v.x, v.y, 0); }
		/// <summary> Explicitly demote a <see cref="Vector3Int"/> into  a <see cref="Vector2Int"/> </summary>
		public static explicit operator Vector2Int(Vector3Int v) { return new Vector2Int(v.x, v.y); }

	}
	#endregion
	//////////////////////////////////////////////////////////////////////////////////////////////////////////
	/////////////////////////////////////////////////////////////////////////////////////////////////////////
	////////////////////////////////////////////////////////////////////////////////////////////////////////
	#region Vector3
	/// <summary> Surrogate class, similar to UnityEngine.Vector3. Stores three <see cref="float"/> components, and provides some math functions. </summary>
	[System.Serializable]
	public struct Vector3 {
		/// <summary> Zero <see cref="Vector3"/> (0,0,0) </summary>
		public static Vector3 zero { get { return new Vector3(0, 0, 0); } }
		/// <summary> One unit <see cref="Vector3"/> (1,1,1) </summary>
		public static Vector3 one { get { return new Vector3(1, 1, 1); } }
		/// <summary> Right unit <see cref="Vector3"/> (1,0,0) </summary>
		public static Vector3 right { get { return new Vector3(1, 0, 0); } }
		/// <summary> Left unit <see cref="Vector3"/> (-1,0,0) </summary>
		public static Vector3 left { get { return new Vector3(-1, 0, 0); } }
		/// <summary> Up unit <see cref="Vector3"/> (0,1,0) </summary>
		public static Vector3 up { get { return new Vector3(0, 1, 0); } }
		/// <summary> Down unit <see cref="Vector3"/> (0,-1,0) </summary>
		public static Vector3 down { get { return new Vector3(0, -1, 0); } }
		/// <summary> Forward unit <see cref="Vector3"/> (0,0,1) </summary>
		public static Vector3 forward { get { return new Vector3(0, 0, 1); } }
		/// <summary> Backward unit <see cref="Vector3"/> (0,0,1) </summary>
		public static Vector3 back { get { return new Vector3(0, 0, -1); } }
		/// <summary> Infinity <see cref="Vector3"/> (+inf, +inf, +inf) </summary>
		public static Vector3 positiveInfinity { get { return new Vector3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity); } }
		/// <summary> Infinity <see cref="Vector3"/> (-inf, -inf, -inf) </summary>
		public static Vector3 negativeInfinity { get { return new Vector3(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity); } }

		/// <summary> Vector component </summary>
		public float x, y, z;
		/// <summary> RGBA Component </summary>
		public float r { get { return x; } set { x = value; } }
		/// <summary> RGBA Component </summary>
		public float g { get { return y; } set { y = value; } }
		/// <summary> RGBA Component </summary>
		public float b { get { return z; } set { z = value; } }

		/// <summary> Create a <see cref="Vector3"/> with the given components </summary>
		public Vector3(float x, float y, float z) { this.x = x; this.y = y; this.z = z; }
		/// <summary> Create a <see cref="Vector3"/> with the given components, and zero for z </summary>
		public Vector3(float x, float y) { this.x = x; this.y = y; z = 0; }
		/// <summary> Index this <see cref="Vector3"/> as an array. Index must be [0, 2] </summary>
		public float this[int i] {
			get { if (i == 0) { return x; } if (i == 1) { return y; } if (i == 2) { return z; } throw new IndexOutOfRangeException($"Vector3 has length=3, {i} is out of range."); }
			set { if (i == 0) { x = value; } if (i == 1) { y = value; } if (i == 2) { z = value; } throw new IndexOutOfRangeException($"Vector3 has length=3, {i} is out of range."); }
		}

		/// <inheritdoc />
		public override bool Equals(object other) { return other is Vector3 && Equals((Vector3)other); }
		/// <summary> Compare this <see cref="Vector3"/> to an<paramref name="other"/> <see cref="Vector3"/> component-wise for equality. </summary>
		public bool Equals(Vector3 other) { return x.Equals(other.x) && y.Equals(other.y) && z.Equals(other.z); }
		/// <inheritdoc />
		public override int GetHashCode() { return x.GetHashCode() ^ (y.GetHashCode() << 2) ^ (z.GetHashCode() >> 2); }
		/// <inheritdoc />
		public override string ToString() { return $"({x:F2}, {y:F2}, {z:F2})"; }


		/// <summary> <see cref="Vector2"/> Swizzle </summary>
		public Vector2 xx { get { return new Vector2(x, x); } }
		/// <summary> <see cref="Vector2"/> Swizzle </summary>
		public Vector2 xy { get { return new Vector2(x, y); } set { x = value.x; y = value.y; } }
		/// <summary> <see cref="Vector2"/> Swizzle </summary>
		public Vector2 xz { get { return new Vector2(x, z); } set { x = value.x; z = value.y; } }
		
		/// <summary> <see cref="Vector2"/> Swizzle </summary>
		public Vector2 yx { get { return new Vector2(y, x); } set { y = value.x; x = value.y; } }
		/// <summary> <see cref="Vector2"/> Swizzle </summary>
		public Vector2 yy { get { return new Vector2(y, y); } }
		/// <summary> <see cref="Vector2"/> Swizzle </summary>
		public Vector2 yz { get { return new Vector2(y, z); } set { y = value.x; z = value.y; } }

		/// <summary> <see cref="Vector2"/> Swizzle </summary>
		public Vector2 zx { get { return new Vector2(z, x); } set { z = value.x; x = value.y; } }
		/// <summary> <see cref="Vector2"/> Swizzle </summary>
		public Vector2 zy { get { return new Vector2(z, y); } set { z = value.x; y = value.y; } }
		/// <summary> <see cref="Vector2"/> Swizzle </summary>
		public Vector2 zz { get { return new Vector2(z, z); } }

		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 xxx { get { return new Vector3(x, x, x); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 xxy { get { return new Vector3(x, x, y); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 xxz { get { return new Vector3(x, x, z); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 xyx { get { return new Vector3(x, y, x); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 xyy { get { return new Vector3(x, y, y); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 xyz { get { return new Vector3(x, y, z); } set { x = value.x; y = value.y; z = value.z; } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 xzx { get { return new Vector3(x, z, x); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 xzy { get { return new Vector3(x, z, y); } set { x = value.x; z = value.y; y = value.z; } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 xzz { get { return new Vector3(x, z, z); } }
		
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 yxx { get { return new Vector3(y, x, x); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 yxy { get { return new Vector3(y, x, y); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 yxz { get { return new Vector3(y, x, z); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 yyx { get { return new Vector3(y, y, x); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 yyy { get { return new Vector3(y, y, y); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 yyz { get { return new Vector3(y, y, z); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 yzx { get { return new Vector3(y, z, x); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 yzy { get { return new Vector3(y, z, y); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 yzz { get { return new Vector3(y, z, z); } }

		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 zxx { get { return new Vector3(z, x, x); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 zxy { get { return new Vector3(z, x, y); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 zxz { get { return new Vector3(z, x, z); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 zyx { get { return new Vector3(z, y, x); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 zyy { get { return new Vector3(z, y, y); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 zyz { get { return new Vector3(z, y, z); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 zzx { get { return new Vector3(z, z, x); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 zzy { get { return new Vector3(z, z, y); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 zzz { get { return new Vector3(z, z, z); } }


		/// <summary> Get a <see cref="Vector3"/> in the same direction as this one, but with a length of one. </summary>
		public Vector3 normalized { get { float m = magnitude; if (m > EPSILON) { return this / m; } return zero; } }
		/// <summary> Get the length of this <see cref="Vector3"/> by distance formula. </summary>
		public float magnitude { get { return Sqrt(x * x + y * y + z * z); } }
		/// <summary> Get the sqr length of this <see cref="Vector3"/> by partial distance formula. Leaving off the <see cref="Sqrt(float)"/>, is slightly faster for length comparisons. </summary>
		public float sqrMagnitude { get { return x * x + y * y + z * z; } }

		/// <summary> Set the x/y/z components of this <see cref="Vector3"/>. Modifies the <see cref="Vector3"/> it was called on. </summary>
		public void Set(float a, float b, float c) { x = a; y = b; z = c; }
		/// <summary> Normalize this <see cref="Vector3"/>. Modifies the <see cref="Vector3"/> it was called on. </summary>
		public void Normalize() { float m = magnitude; if (m > EPSILON) { this /= m; } else { this = zero; } }
		/// <summary> Scale this <see cref="Vector3"/> componentwise by another. Modifies the <see cref="Vector3"/> it was called on. </summary>
		public void Scale(Vector3 s) { x *= s.x; y *= s.y; z *= s.z; }
		/// <summary> Clamp this <see cref="Vector3"/> between two other <see cref="Vector3"/>s. Modifies the <see cref="Vector3"/> it was called on. </summary>
		public void Clamp(Vector3 min, Vector3 max) {
			x = Mathf.Clamp(x, min.x, max.x);
			y = Mathf.Clamp(y, min.y, max.y);
			z = Mathf.Clamp(z, min.z, max.z);
		}


		/// <summary> <see cref="Mathf.FloorToInt(float)"/>'s each component in this <see cref="Vector3"/> to produce a <see cref="Vector3Int"/></summary>
		public Vector3Int FloorToInt() { return new Vector3Int(Mathf.FloorToInt(x), Mathf.FloorToInt(y), Mathf.FloorToInt(z)); }
		/// <summary> <see cref="Mathf.CeilToInt(float)"/>'s each component in this <see cref="Vector3"/> to produce a <see cref="Vector3Int"/></summary>
		public Vector3Int CeilToInt() { return new Vector3Int(Mathf.CeilToInt(x), Mathf.CeilToInt(y), Mathf.CeilToInt(z)); }
		/// <summary> <see cref="Mathf.RoundToInt(float)"/>'s each component in this <see cref="Vector3"/> to produce a <see cref="Vector3Int"/></summary>
		public Vector3Int RoundToInt() { return new Vector3Int(Mathf.RoundToInt(x), Mathf.RoundToInt(y), Mathf.RoundToInt(z)); }

		/// <summary> Get component-wise absolute value of this <see cref="Vector3"/>. </summary>
		public Vector3 Abs() { return new Vector3(Mathf.Abs(x), Mathf.Abs(y), Mathf.Abs(z)); }

		/// <summary> Get component-wise absolute value of given <see cref="Vector3"/>. </summary>
		public static Vector3 Abs(Vector3 v) { return new Vector3(Mathf.Abs(v.x), Mathf.Abs(v.y), Mathf.Abs(v.z)); }

		/// <summary> Componentwise Minimum of two <see cref="Vector3"/>s </summary>
		public static Vector3 Min(Vector3 a, Vector3 b) { return new Vector3(Mathf.Min(a.x, b.x), Mathf.Min(a.y, b.y), Mathf.Min(a.z, b.z)); }
		/// <summary> Componentwise Maximum of two <see cref="Vector3"/>s </summary>
		public static Vector3 Max(Vector3 a, Vector3 b) { return new Vector3(Mathf.Max(a.x, b.x), Mathf.Max(a.y, b.y), Mathf.Max(a.z, b.z)); }

		/// <summary> Calculate <see cref="Vector3"/> Cross product, via left-hand rule. </summary>
		public static Vector3 Cross(Vector3 a, Vector3 b) {
			return new Vector3(a.y * b.z - a.z * b.y,
								a.z * b.x - a.x * b.y,
								a.x * b.y - a.y * b.x);
		}
		/// <summary> Calculate dot product of two <see cref="Vector3"/>s </summary>
		public static float Dot(Vector3 a, Vector3 b) { return a.x * b.x + a.y * b.y + a.z * b.z; }
		/// <summary> Reflect a <paramref name="dir"/>ection <see cref="Vector3"/> about the given <paramref name="normal"/></summary>
		public static Vector3 Reflect(Vector3 dir, Vector3 normal) { return -2f * Dot(normal, dir) * normal + dir; }
		/// <summary> Project a <paramref name="dir"/>ection <see cref="Vector3"/> along the given <paramref name="normal"/></summary>
		public static Vector3 Project(Vector3 dir, Vector3 normal) {
			float len = Dot(normal, normal);
			return (len < SQR_EPSILON) ? zero : normal * Dot(dir, normal) / len;
		}
		/// <summary> Project the given <paramref name="v"/>ector onto a plane through the origin, defined by the given <paramref name="normal"/></summary>
		public static Vector3 ProjectOnPlane(Vector3 v, Vector3 normal) { return v - Project(v, normal); }
		/// <summary> Calculate the angle between two <see cref="Vector3"/>s. </summary>
		public static float Angle(Vector3 from, Vector3 to) {
			float e = Sqrt(from.sqrMagnitude * to.sqrMagnitude);
			if (e < SQR_EPSILON) { return 0; }
			float f = Mathf.Clamp(Dot(from, to) / e, -1f, 1f);
			return Acos(f) * Rad2Deg;
		}
		/// <summary> Get the signed angle between two <see cref="Vector3"/>s, in regards to the given <paramref name="axis"/>. </summary>
		public static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis) {
			float angle = Angle(from, to);
			float sign = Sign(Dot(axis, Cross(from, to)));
			return sign * angle;
		}
		/// <summary> Get the distance between two <see cref="Vector3"/>s </summary>
		public static float Distance(Vector3 a, Vector3 b) {
			Vector3 v = new Vector3(a.x - b.x, a.y - b.y, a.z - b.z);
			return Sqrt(v.x * v.x + v.y * v.y + v.z * v.z);
		}
		/// <summary> Clamp the magnitude of a <paramref name="vector"/> so it is not longer than <paramref name="maxLength"/>. </summary>
		public static Vector3 ClampMagnitude(Vector3 vector, float maxLength) {
			return (vector.sqrMagnitude > maxLength * maxLength) ? vector.normalized * maxLength : vector;
		}
		/// <summary> Lineraly interpolate between <see cref="Vector3"/>s <paramref name="a"/> and <paramref name="b"/> by proportion <paramref name="f"/> </summary>
		public static Vector3 Lerp(Vector3 a, Vector3 b, float f) { f = Clamp01(f); return new Vector3(a.x + (b.x - a.x) * f, a.y + (b.y - a.y) * f, a.z + (b.z - a.z) * f); }
		/// <summary> Lineraly interpolate between <see cref="Vector3"/>s <paramref name="a"/> and <paramref name="b"/> by proportion <paramref name="f"/>, without a <see cref="Mathf.Clamp01(float)"/>. </summary>
		public static Vector3 LerpUnclamped(Vector3 a, Vector3 b, float f) { return new Vector3(a.x + (b.x - a.x) * f, a.y + (b.y - a.y) * f, a.z + (b.z - a.z) * f); }
		/// <summary> Move <paramref name="current"/> <see cref="Vector3"/> towards <paramref name="target"/>, at most changing by <paramref name="maxDistanceDelta"/> units. </summary>
		public static Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta) {
			Vector3 a = target - current;
			float m = a.magnitude;
			return (m < maxDistanceDelta || m == 0f) ? target : (current + a / m * maxDistanceDelta);
		}
		/// <summary> Negate each component of the given <see cref="Vector3"/> </summary>
		public static Vector3 operator -(Vector3 a) { return new Vector3(-a.x, -a.y, -a.z); }
		/// <summary> Add two <see cref="Vector3"/>s together </summary>
		public static Vector3 operator +(Vector3 a, Vector3 b) { return new Vector3(a.x + b.x, a.y + b.y, a.z + b.z); }
		/// <summary> Subtract one <see cref="Vector3"/> from another </summary>
		public static Vector3 operator -(Vector3 a, Vector3 b) { return new Vector3(a.x - b.x, a.y - b.y, a.z - b.z); }
		/// <summary> Multiply two <see cref="Vector3"/>s together  </summary>
		public static Vector3 operator *(Vector3 a, Vector3 b) { return new Vector3(a.x * b.x, a.y * b.y, a.z * b.z); }
		/// <summary> Divide one <see cref="Vector3"/> from another  </summary>
		public static Vector3 operator /(Vector3 a, Vector3 b) { return new Vector3(a.x / b.x, a.y / b.y, a.z / b.z); }
		/// <summary> Multiply a <see cref="Vector3"/> by a scalar </summary>
		public static Vector3 operator *(Vector3 a, float f) { return new Vector3(a.x * f, a.y * f, a.z * f); }
		/// <summary> Multiply a <see cref="Vector3"/> by a scalar </summary>
		public static Vector3 operator *(float f, Vector3 a) { return new Vector3(a.x * f, a.y * f, a.z * f); }
		/// <summary> Divide a <see cref="Vector3"/> by a scalar </summary>
		public static Vector3 operator /(Vector3 a, float f) { return new Vector3(a.x / f, a.y / f, a.z / f); }
		/// <summary> Inverse divide a <see cref="Vector3"/> by a scalar </summary>
		public static Vector3 operator /(float f, Vector3 a) { return new Vector3(f / a.x, f / a.y, f / a.z); }
		/// <summary> Compare two <see cref="Vector3"/>s by their square distance being below <see cref="COMPARE_EPSILON"/>. </summary>
		public static bool operator ==(Vector3 a, Vector3 b) { return (a - b).sqrMagnitude < COMPARE_EPSILON; }
		/// <summary> Inverse compare two <see cref="Vector3"/>s by their square distance being below <see cref="COMPARE_EPSILON"/>. </summary>
		public static bool operator !=(Vector3 a, Vector3 b) { return !(a == b); }

	}
	#endregion
	//////////////////////////////////////////////////////////////////////////////////////////////////////////
	/////////////////////////////////////////////////////////////////////////////////////////////////////////
	////////////////////////////////////////////////////////////////////////////////////////////////////////
	#region Vector3Int
	/// <summary> Surrogate class, similar to UnityEngine.Vector3Int. Stores three <see cref="int"/> components, and provides some math functions. </summary>
	[System.Serializable]
	public struct Vector3Int : IEquatable<Vector3Int> {
		/// <summary> Zero <see cref="Vector3Int"/> (0,0,0) </summary>
		public static Vector3Int zero { get { return new Vector3Int(0, 0, 0); } }
		/// <summary> One unit <see cref="Vector3Int"/> (1,1,1) </summary>
		public static Vector3Int one { get { return new Vector3Int(0, 0, 0); } }
		/// <summary> Right unit <see cref="Vector3Int"/> (1,0,0) </summary>
		public static Vector3Int right { get { return new Vector3Int(1, 0, 0); } }
		/// <summary> Left unit <see cref="Vector3Int"/> (-1,0,0) </summary>
		public static Vector3Int left { get { return new Vector3Int(-1, 0, 0); } }
		/// <summary> Up unit <see cref="Vector3Int"/> (0,1,0) </summary>
		public static Vector3Int up { get { return new Vector3Int(0, 1, 0); } }
		/// <summary> Down unit <see cref="Vector3Int"/> (0,-1,0) </summary>
		public static Vector3Int down { get { return new Vector3Int(0, -1, 0); } }
		/// <summary> Forward unit <see cref="Vector3Int"/> (0,0,1) </summary>
		public static Vector3Int forward { get { return new Vector3Int(0, 0, 1); } }
		/// <summary> Down unit <see cref="Vector3Int"/> (0,0,-1) </summary>
		public static Vector3Int back { get { return new Vector3Int(0, 0, -1); } }

		/// <summary> Vector component </summary>
		public int x, y, z;
		/// <summary> Construct a <see cref="Vector3Int"/> with the given components </summary>
		public Vector3Int(int x, int y, int z) { this.x = x; this.y = y; this.z = z; }
		/// <summary> Index this <see cref="Vector3Int"/> as an array. Index must be in range [0, 2] </summary>
		public int this[int i] {
			get { if (i == 0) { return x; } if (i == 1) { return y; } if (i == 2) { return z; } throw new IndexOutOfRangeException($"Vector3Int has length=3, {i} is out of range."); }
			set { if (i == 0) { x = value; } if (i == 1) { y = value; } if (i == 2) { z = value; } throw new IndexOutOfRangeException($"Vector3Int has length=3, {i} is out of range."); }
		}

		/// <inheritdoc />
		public override bool Equals(object other) { return other is Vector3Int && Equals((Vector3Int)other); }
		/// <summary> Compare <see cref="Vector3Int"/>s by their components being equal. </summary>
		public bool Equals(Vector3Int other) { return this == other; }
		/// <inheritdoc />
		public override int GetHashCode() {
			int yy = y.GetHashCode(); int zz = z.GetHashCode(); int xx = x.GetHashCode();
			return xx ^ (yy << 4) ^ (yy >> 28) ^ (zz >> 4) ^ (zz << 28);
		}
		/// <inheritdoc />
		public override string ToString() { return $"({x}, {y}, {z})"; }

		/// <summary> <see cref="Vector2"/> Swizzle </summary>
		public Vector2 xx { get { return new Vector2(x, x); } }
		/// <summary> <see cref="Vector2"/> Swizzle </summary>
		public Vector2 xy { get { return new Vector2(x, y); } }
		/// <summary> <see cref="Vector2"/> Swizzle </summary>
		public Vector2 xz { get { return new Vector2(x, z); } }

		/// <summary> <see cref="Vector2"/> Swizzle </summary>
		public Vector2 yx { get { return new Vector2(y, x); } }
		/// <summary> <see cref="Vector2"/> Swizzle </summary>
		public Vector2 yy { get { return new Vector2(y, y); } }
		/// <summary> <see cref="Vector2"/> Swizzle </summary>
		public Vector2 yz { get { return new Vector2(y, z); } }

		/// <summary> <see cref="Vector2"/> Swizzle </summary>
		public Vector2 zx { get { return new Vector2(z, x); } }
		/// <summary> <see cref="Vector2"/> Swizzle </summary>
		public Vector2 zy { get { return new Vector2(z, y); } }
		/// <summary> <see cref="Vector2"/> Swizzle </summary>
		public Vector2 zz { get { return new Vector2(z, z); } }

		/// <summary> <see cref="Vector3Int"/> Swizzle </summary>
		public Vector3Int xxx { get { return new Vector3Int(x, x, x); } }
		/// <summary> <see cref="Vector3Int"/> Swizzle </summary>
		public Vector3Int xxy { get { return new Vector3Int(x, x, y); } }
		/// <summary> <see cref="Vector3Int"/> Swizzle </summary>
		public Vector3Int xxz { get { return new Vector3Int(x, x, z); } }
		/// <summary> <see cref="Vector3Int"/> Swizzle </summary>
		public Vector3Int xyx { get { return new Vector3Int(x, y, x); } }
		/// <summary> <see cref="Vector3Int"/> Swizzle </summary>
		public Vector3Int xyy { get { return new Vector3Int(x, y, y); } }
		/// <summary> <see cref="Vector3Int"/> Swizzle </summary>
		public Vector3Int xyz { get { return new Vector3Int(x, y, z); } }
		/// <summary> <see cref="Vector3Int"/> Swizzle </summary>
		public Vector3Int xzx { get { return new Vector3Int(x, z, x); } }
		/// <summary> <see cref="Vector3Int"/> Swizzle </summary>
		public Vector3Int xzy { get { return new Vector3Int(x, z, y); } }
		/// <summary> <see cref="Vector3Int"/> Swizzle </summary>
		public Vector3Int xzz { get { return new Vector3Int(x, z, z); } }

		/// <summary> <see cref="Vector3Int"/> Swizzle </summary>
		public Vector3Int yxx { get { return new Vector3Int(y, x, x); } }
		/// <summary> <see cref="Vector3Int"/> Swizzle </summary>
		public Vector3Int yxy { get { return new Vector3Int(y, x, y); } }
		/// <summary> <see cref="Vector3Int"/> Swizzle </summary>
		public Vector3Int yxz { get { return new Vector3Int(y, x, z); } }
		/// <summary> <see cref="Vector3Int"/> Swizzle </summary>
		public Vector3Int yyx { get { return new Vector3Int(y, y, x); } }
		/// <summary> <see cref="Vector3Int"/> Swizzle </summary>
		public Vector3Int yyy { get { return new Vector3Int(y, y, y); } }
		/// <summary> <see cref="Vector3Int"/> Swizzle </summary>
		public Vector3Int yyz { get { return new Vector3Int(y, y, z); } }
		/// <summary> <see cref="Vector3Int"/> Swizzle </summary>
		public Vector3Int yzx { get { return new Vector3Int(y, z, x); } }
		/// <summary> <see cref="Vector3Int"/> Swizzle </summary>
		public Vector3Int yzy { get { return new Vector3Int(y, z, y); } }
		/// <summary> <see cref="Vector3Int"/> Swizzle </summary>
		public Vector3Int yzz { get { return new Vector3Int(y, z, z); } }

		/// <summary> <see cref="Vector3Int"/> Swizzle </summary>
		public Vector3Int zxx { get { return new Vector3Int(z, x, x); } }
		/// <summary> <see cref="Vector3Int"/> Swizzle </summary>
		public Vector3Int zxy { get { return new Vector3Int(z, x, y); } }
		/// <summary> <see cref="Vector3Int"/> Swizzle </summary>
		public Vector3Int zxz { get { return new Vector3Int(z, x, z); } }
		/// <summary> <see cref="Vector3Int"/> Swizzle </summary>
		public Vector3Int zyx { get { return new Vector3Int(z, y, x); } }
		/// <summary> <see cref="Vector3Int"/> Swizzle </summary>
		public Vector3Int zyy { get { return new Vector3Int(z, y, y); } }
		/// <summary> <see cref="Vector3Int"/> Swizzle </summary>
		public Vector3Int zyz { get { return new Vector3Int(z, y, z); } }
		/// <summary> <see cref="Vector3Int"/> Swizzle </summary>
		public Vector3Int zzx { get { return new Vector3Int(z, z, x); } }
		/// <summary> <see cref="Vector3Int"/> Swizzle </summary>
		public Vector3Int zzy { get { return new Vector3Int(z, z, y); } }
		/// <summary> <see cref="Vector3Int"/> Swizzle </summary>
		public Vector3Int zzz { get { return new Vector3Int(z, z, z); } }

		/// <summary> <see cref="Vector3Int"/> length by distance formula </summary>
		public float magnitude { get { return Sqrt(x * x + y * y + z * z); } }
		/// <summary> Square <see cref="Vector3Int"/> length by partial distance formula. Slightly faster for length comparisons due to skipping the <see cref="Sqrt(float)"/> </summary>
		public int sqrMagnitude { get { return x * x + y * y + z * z; } }

		/// <summary> Set each component of this <see cref="Vector3Int"/>. Changes the <see cref="Vector3Int"/> it is called on. </summary>
		public void Set(int a, int b, int c) { x = a; y = b; z = c; }
		/// <summary> Scale this <see cref="Vector3Int"/> component-wise. Changes the <see cref="Vector3Int"/> it is called on. </summary>
		public void Scale(Vector3Int scale) { x *= scale.x; y *= scale.y; z *= scale.z; }
		/// <summary> Clamp this <see cref="Vector3Int"/> between two other <see cref="Vector3Int"/>s. Changes the vector it is called on. </summary>
		public void Clamp(Vector3 min, Vector3 max) {
			x = (int)Mathf.Clamp(x, min.x, max.x);
			y = (int)Mathf.Clamp(y, min.y, max.y);
			z = (int)Mathf.Clamp(z, min.z, max.z);
		}

		/// <summary> Get component-wise absolute value of this <see cref="Vector3Int"/>. </summary>
		public Vector3Int Abs() { return new Vector3Int(Mathf.Abs(x), Mathf.Abs(y), Mathf.Abs(z)); }

		/// <summary> Get component-wise absolute value of given <see cref="Vector3Int"/>. </summary>
		public static Vector3Int Abs(Vector3Int v) { return new Vector3Int(Mathf.Abs(v.x), Mathf.Abs(v.y), Mathf.Abs(v.z)); }

		/// <summary> Component-wise minimum of two <see cref="Vector3Int"/>s </summary>
		public static Vector3Int Min(Vector3Int a, Vector3Int b) { return new Vector3Int(Mathf.Min(a.x, b.x), Mathf.Min(a.y, b.y), Mathf.Min(a.z, b.z)); }
		/// <summary> Component-wise maximum of two <see cref="Vector3Int"/>s </summary>
		public static Vector3Int Max(Vector3Int a, Vector3Int b) { return new Vector3Int(Mathf.Max(a.x, b.x), Mathf.Max(a.y, b.y), Mathf.Max(a.z, b.z)); }
		/// <summary> Component-wise scale a <see cref="Vector3Int"/> by another </summary>
		public static Vector3Int Scale(Vector3Int a, Vector3Int b) { return new Vector3Int(a.x * b.x, a.y * b.y, a.z * b.z); }
		/// <summary> Get the distance between two <see cref="Vector3Int"/>s </summary>
		public static float Distance(Vector3Int a, Vector3Int b) { return (a - b).magnitude; }


		/// <summary> Negate each component of the given <see cref="Vector3Int"/> </summary>
		public static Vector3Int operator -(Vector3Int a) { return new Vector3Int(-a.x, -a.y, -a.z); }
		/// <summary> Add two <see cref="Vector3Int"/>s together </summary>
		public static Vector3Int operator +(Vector3Int a, Vector3Int b) { return new Vector3Int(a.x + b.x, a.y + b.y, a.z + b.z); }
		/// <summary> Subtract one <see cref="Vector3Int"/> from another </summary>
		public static Vector3Int operator -(Vector3Int a, Vector3Int b) { return new Vector3Int(a.x - b.x, a.y - b.y, a.z - b.z); }
		/// <summary> Multiply two <see cref="Vector3Int"/>s together  </summary>
		public static Vector3Int operator *(Vector3Int a, Vector3Int b) { return new Vector3Int(a.x * b.x, a.y * b.y, a.z * b.z); }
		/// <summary> Divide one <see cref="Vector3Int"/> from another  </summary>
		public static Vector3Int operator /(Vector3Int a, Vector3Int b) { return new Vector3Int(a.x / b.x, a.y / b.y, a.z / b.z); }
		/// <summary> Multiply a <see cref="Vector3Int"/> by a scalar </summary>
		public static Vector3Int operator *(Vector3Int a, int i) { return new Vector3Int(a.x * i, a.y * i, a.z * i); }
		/// <summary> Multiply a <see cref="Vector3Int"/> by a scalar </summary>
		public static Vector3Int operator *(int i, Vector3Int a) { return new Vector3Int(a.x * i, a.y * i, a.z * i); }
		/// <summary> Divide a <see cref="Vector3Int"/> by a scalar </summary>
		public static Vector3Int operator /(Vector3Int a, int i) { return new Vector3Int(a.x / i, a.y / i, a.z / i); }
		/// <summary> Inverse divide a <see cref="Vector3Int"/> by a scalar </summary>
		public static Vector3Int operator /(int i, Vector3Int a) { return new Vector3Int(i / a.x, i / a.y, i / a.z); }
		/// <summary> Compare two <see cref="Vector3Int"/>s by their components for equality. </summary>
		public static bool operator ==(Vector3Int a, Vector3Int b) { return a.x == b.x && a.y == b.y && a.z == b.z; }
		/// <summary> Inverse compare two <see cref="Vector3Int"/>s by their components for equality. </summary>
		public static bool operator !=(Vector3Int a, Vector3Int b) { return !(a == b); }

		/// <summary> Automatically promote a <see cref="Vector3Int"/> into a <see cref="Vector3"/></summary>
		public static implicit operator Vector3(Vector3Int v) { return new Vector3(v.x, v.y, v.z); }
		/// <summary> Automatically promote a <see cref="Vector2Int"/> into a <see cref="Vector3Int"/></summary>
		public static implicit operator Vector3Int(Vector2Int v) { return new Vector3Int(v.x, v.y, 0); }
		/// <summary> Explicitly demote a <see cref="Vector3Int"/> into a <see cref="Vector2Int"/></summary>
		public static explicit operator Vector2Int(Vector3Int v) { return new Vector2Int(v.x, v.y); }
	}
	#endregion
	#region Vector4 
	//////////////////////////////////////////////////////////////////////////////////////////////////////////
	/////////////////////////////////////////////////////////////////////////////////////////////////////////
	////////////////////////////////////////////////////////////////////////////////////////////////////////
	/// <summary> Surrogate class, similar to UnityEngine.Vector4. Stores four <see cref="float"/> components, and provides some math functions. </summary>
	[System.Serializable]
	public struct Vector4 {
		/// <summary> Zero <see cref="Vector4"/> (0,0,0,0) </summary>
		public static Vector4 zero { get { return new Vector4(0, 0, 0, 0); } }
		/// <summary> One unit <see cref="Vector4"/> (1,1,1,1) </summary>
		public static Vector4 one { get { return new Vector4(1, 1, 1, 1); } }
		/// <summary> Infinity <see cref="Vector4"/> (+inf, +inf, +inf, +inf) </summary>
		public static Vector4 positiveInfinity { get { return new Vector4(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity); } }
		/// <summary> Infinity <see cref="Vector4"/> (-inf, -inf, -inf, -inf) </summary>
		public static Vector4 negativeInfinity { get { return new Vector4(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity); } }

		/// <summary> Vector component </summary>
		public float x, y, z, w;
		/// <summary> RGBA Component </summary>
		public float r { get { return x; } set { x = value; } }
		/// <summary> RGBA Component </summary>
		public float g { get { return y; } set { y = value; } }
		/// <summary> RGBA Component </summary>
		public float b { get { return z; } set { z = value; } }
		/// <summary> RGBA Component </summary>
		public float a { get { return w; } set { w = value; } }

		/// <summary> Create a <see cref="Vector4"/> with the given components </summary>
		public Vector4(float x, float y, float z, float w) { this.x = x; this.y = y; this.z = z; this.w = w; }
		/// <summary> Index this <see cref="Vector4"/> as if it was an array. Index must be [0, 3] </summary>
		public float this[int i] {
			get {
				if (i == 0) { return x; } if (i == 1) { return y; } if (i == 2) { return z; } if (i == 3) { return w; }
				throw new IndexOutOfRangeException($"Vector4 has length=4, {i} is out of range.");
			}
			set {
				if (i == 0) { x = value; } if (i == 1) { y = value; } if (i == 2) { z = value; } if (i == 3) { w = value; }
				throw new IndexOutOfRangeException($"Vector4 has length=4, {i} is out of range.");
			}
		}

		/// <inheritdoc />
		public override bool Equals(object other) { return other is Vector4 && Equals((Vector4)other); }
		/// <summary> Compare two <see cref="Vector4"/> componentwise for equality </summary>
		public bool Equals(Vector4 other) { return x.Equals(other.x) && y.Equals(other.y) && z.Equals(other.z) && w.Equals(other.w); }
		/// <inheritdoc />
		public override int GetHashCode() {
			int yy = y.GetHashCode(); int zz = z.GetHashCode(); int xx = x.GetHashCode(); int ww = w.GetHashCode();
			return xx ^ (yy << 2) ^ (zz >> 2) ^ (ww >> 1);
		}
		/// <inheritdoc />
		public override string ToString() { return $"({x}, {y}, {z}, {w})"; }

		#region Vector4 Swizzles
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xxxx { get { return new Vector4(x, x, x, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xxxy { get { return new Vector4(x, x, x, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xxxz { get { return new Vector4(x, x, x, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xxxw { get { return new Vector4(x, x, x, w); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xxyx { get { return new Vector4(x, x, y, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xxyy { get { return new Vector4(x, x, y, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xxyz { get { return new Vector4(x, x, y, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xxyw { get { return new Vector4(x, x, y, w); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xxzx { get { return new Vector4(x, x, z, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xxzy { get { return new Vector4(x, x, z, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xxzz { get { return new Vector4(x, x, z, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xxzw { get { return new Vector4(x, x, z, w); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xxwx { get { return new Vector4(x, x, w, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xxwy { get { return new Vector4(x, x, w, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xxwz { get { return new Vector4(x, x, w, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xxww { get { return new Vector4(x, x, w, w); } }

		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xyxx { get { return new Vector4(x, y, x, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xyxy { get { return new Vector4(x, y, x, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xyxz { get { return new Vector4(x, y, x, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xyxw { get { return new Vector4(x, y, x, w); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xyyx { get { return new Vector4(x, y, y, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xyyy { get { return new Vector4(x, y, y, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xyyz { get { return new Vector4(x, y, y, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xyyw { get { return new Vector4(x, y, y, w); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xyzx { get { return new Vector4(x, y, z, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xyzy { get { return new Vector4(x, y, z, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xyzz { get { return new Vector4(x, y, z, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xyzw { get { return new Vector4(x, y, z, w); } set { x = value.x; y = value.y; z = value.z; w = value.w; }  }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xywx { get { return new Vector4(x, y, w, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xywy { get { return new Vector4(x, y, w, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xywz { get { return new Vector4(x, y, w, z); } set { x = value.x; y = value.y; w = value.z; z = value.w; } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xyww { get { return new Vector4(x, y, w, w); } }

		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xzxx { get { return new Vector4(x, z, x, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xzxy { get { return new Vector4(x, z, x, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xzxz { get { return new Vector4(x, z, x, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xzxw { get { return new Vector4(x, z, x, w); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xzyx { get { return new Vector4(x, z, y, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xzyy { get { return new Vector4(x, z, y, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xzyz { get { return new Vector4(x, z, y, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xzyw { get { return new Vector4(x, z, y, w); } set { x = value.x; z = value.y; y = value.z; w = value.w; } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xzzx { get { return new Vector4(x, z, z, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xzzy { get { return new Vector4(x, z, z, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xzzz { get { return new Vector4(x, z, z, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xzzw { get { return new Vector4(x, z, z, w); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xzwx { get { return new Vector4(x, z, w, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xzwy { get { return new Vector4(x, z, w, y); } set { x = value.x; z = value.y; w = value.z; y = value.w; } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xzwz { get { return new Vector4(x, z, w, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xzww { get { return new Vector4(x, z, w, w); } }

		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xwxx { get { return new Vector4(x, w, x, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xwxy { get { return new Vector4(x, w, x, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xwxz { get { return new Vector4(x, w, x, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xwxw { get { return new Vector4(x, w, x, w); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xwyx { get { return new Vector4(x, w, y, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xwyy { get { return new Vector4(x, w, y, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xwyz { get { return new Vector4(x, w, y, z); } set { x = value.x; w = value.y; y = value.z; z = value.w; } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xwyw { get { return new Vector4(x, w, y, w); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xwzx { get { return new Vector4(x, w, z, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xwzy { get { return new Vector4(x, w, z, y); } set { x = value.x; w = value.y; z = value.z; y = value.w; } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xwzz { get { return new Vector4(x, w, z, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xwzw { get { return new Vector4(x, w, z, w); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xwwx { get { return new Vector4(x, w, w, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xwwy { get { return new Vector4(x, w, w, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xwwz { get { return new Vector4(x, w, w, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 xwww { get { return new Vector4(x, w, w, w); } }

		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yxxx { get { return new Vector4(y, x, x, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yxxy { get { return new Vector4(y, x, x, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yxxz { get { return new Vector4(y, x, x, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yxxw { get { return new Vector4(y, x, x, w); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yxyx { get { return new Vector4(y, x, y, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yxyy { get { return new Vector4(y, x, y, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yxyz { get { return new Vector4(y, x, y, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yxyw { get { return new Vector4(y, x, y, w); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yxzx { get { return new Vector4(y, x, z, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yxzy { get { return new Vector4(y, x, z, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yxzz { get { return new Vector4(y, x, z, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yxzw { get { return new Vector4(y, x, z, w); } set { y = value.x; x = value.y; z = value.z; w = value.w; } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yxwx { get { return new Vector4(y, x, w, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yxwy { get { return new Vector4(y, x, w, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yxwz { get { return new Vector4(y, x, w, z); } set { y = value.x; x = value.y; w = value.z; z = value.w; } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yxww { get { return new Vector4(y, x, w, w); } }

		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yyxx { get { return new Vector4(y, y, x, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yyxy { get { return new Vector4(y, y, x, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yyxz { get { return new Vector4(y, y, x, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yyxw { get { return new Vector4(y, y, x, w); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yyyx { get { return new Vector4(y, y, y, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yyyy { get { return new Vector4(y, y, y, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yyyz { get { return new Vector4(y, y, y, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yyyw { get { return new Vector4(y, y, y, w); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yyzx { get { return new Vector4(y, y, z, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yyzy { get { return new Vector4(y, y, z, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yyzz { get { return new Vector4(y, y, z, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yyzw { get { return new Vector4(y, y, z, w); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yywx { get { return new Vector4(y, y, w, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yywy { get { return new Vector4(y, y, w, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yywz { get { return new Vector4(y, y, w, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yyww { get { return new Vector4(y, y, w, w); } }

		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yzxx { get { return new Vector4(y, z, x, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yzxy { get { return new Vector4(y, z, x, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yzxz { get { return new Vector4(y, z, x, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yzxw { get { return new Vector4(y, z, x, w); } set { y = value.x; z = value.y; x = value.z; w = value.w; } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yzyx { get { return new Vector4(y, z, y, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yzyy { get { return new Vector4(y, z, y, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yzyz { get { return new Vector4(y, z, y, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yzyw { get { return new Vector4(y, z, y, w); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yzzx { get { return new Vector4(y, z, z, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yzzy { get { return new Vector4(y, z, z, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yzzz { get { return new Vector4(y, z, z, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yzzw { get { return new Vector4(y, z, z, w); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yzwx { get { return new Vector4(y, z, w, x); } set { y = value.x; z = value.y; w = value.z; x = value.w; } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yzwy { get { return new Vector4(y, z, w, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yzwz { get { return new Vector4(y, z, w, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 yzww { get { return new Vector4(y, z, w, w); } }

		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 ywxx { get { return new Vector4(y, w, x, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 ywxy { get { return new Vector4(y, w, x, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 ywxz { get { return new Vector4(y, w, x, z); } set { y = value.x; w = value.y; x = value.z; z = value.w; } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 ywxw { get { return new Vector4(y, w, x, w); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 ywyx { get { return new Vector4(y, w, y, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 ywyy { get { return new Vector4(y, w, y, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 ywyz { get { return new Vector4(y, w, y, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 ywyw { get { return new Vector4(y, w, y, w); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 ywzx { get { return new Vector4(y, w, z, x); } set { y = value.x; w = value.y; z = value.z; x = value.w; } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 ywzy { get { return new Vector4(y, w, z, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 ywzz { get { return new Vector4(y, w, z, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 ywzw { get { return new Vector4(y, w, z, w); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 ywwx { get { return new Vector4(y, w, w, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 ywwy { get { return new Vector4(y, w, w, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 ywwz { get { return new Vector4(y, w, w, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 ywww { get { return new Vector4(y, w, w, w); } }

		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zxxx { get { return new Vector4(z, x, x, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zxxy { get { return new Vector4(z, x, x, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zxxz { get { return new Vector4(z, x, x, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zxxw { get { return new Vector4(z, x, x, w); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zxyx { get { return new Vector4(z, x, y, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zxyy { get { return new Vector4(z, x, y, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zxyz { get { return new Vector4(z, x, y, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zxyw { get { return new Vector4(z, x, y, w); } set { z = value.x; x = value.y; y = value.z; w = value.w; } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zxzx { get { return new Vector4(z, x, z, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zxzy { get { return new Vector4(z, x, z, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zxzz { get { return new Vector4(z, x, z, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zxzw { get { return new Vector4(z, x, z, w); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zxwx { get { return new Vector4(z, x, w, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zxwy { get { return new Vector4(z, x, w, y); } set { z = value.x; x = value.y; w = value.z; y = value.w; } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zxwz { get { return new Vector4(z, x, w, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zxww { get { return new Vector4(z, x, w, w); } }

		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zyxx { get { return new Vector4(z, y, x, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zyxy { get { return new Vector4(z, y, x, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zyxz { get { return new Vector4(z, y, x, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zyxw { get { return new Vector4(z, y, x, w); } set { z = value.x; y = value.y; x = value.z; w = value.w; } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zyyx { get { return new Vector4(z, y, y, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zyyy { get { return new Vector4(z, y, y, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zyyz { get { return new Vector4(z, y, y, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zyyw { get { return new Vector4(z, y, y, w); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zyzx { get { return new Vector4(z, y, z, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zyzy { get { return new Vector4(z, y, z, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zyzz { get { return new Vector4(z, y, z, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zyzw { get { return new Vector4(z, y, z, w); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zywx { get { return new Vector4(z, y, w, x); } set { z = value.x; y = value.y; w = value.z; x = value.w; } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zywy { get { return new Vector4(z, y, w, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zywz { get { return new Vector4(z, y, w, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zyww { get { return new Vector4(z, y, w, w); } }

		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zzxx { get { return new Vector4(z, z, x, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zzxy { get { return new Vector4(z, z, x, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zzxz { get { return new Vector4(z, z, x, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zzxw { get { return new Vector4(z, z, x, w); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zzyx { get { return new Vector4(z, z, y, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zzyy { get { return new Vector4(z, z, y, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zzyz { get { return new Vector4(z, z, y, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zzyw { get { return new Vector4(z, z, y, w); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zzzx { get { return new Vector4(z, z, z, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zzzy { get { return new Vector4(z, z, z, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zzzz { get { return new Vector4(z, z, z, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zzzw { get { return new Vector4(z, z, z, w); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zzwx { get { return new Vector4(z, z, w, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zzwy { get { return new Vector4(z, z, w, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zzwz { get { return new Vector4(z, z, w, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zzww { get { return new Vector4(z, z, w, w); } }

		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zwxx { get { return new Vector4(z, w, x, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zwxy { get { return new Vector4(z, w, x, y); } set { z = value.x; w = value.y; x = value.z; y = value.w; } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zwxz { get { return new Vector4(z, w, x, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zwxw { get { return new Vector4(z, w, x, w); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zwyx { get { return new Vector4(z, w, y, x); } set { z = value.x; w = value.y; y = value.z; x = value.w; } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zwyy { get { return new Vector4(z, w, y, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zwyz { get { return new Vector4(z, w, y, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zwyw { get { return new Vector4(z, w, y, w); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zwzx { get { return new Vector4(z, w, z, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zwzy { get { return new Vector4(z, w, z, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zwzz { get { return new Vector4(z, w, z, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zwzw { get { return new Vector4(z, w, z, w); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zwwx { get { return new Vector4(z, w, w, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zwwy { get { return new Vector4(z, w, w, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zwwz { get { return new Vector4(z, w, w, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 zwww { get { return new Vector4(z, w, w, w); } }

		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wxxx { get { return new Vector4(w, x, x, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wxxy { get { return new Vector4(w, x, x, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wxxz { get { return new Vector4(w, x, x, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wxxw { get { return new Vector4(w, x, x, w); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wxyx { get { return new Vector4(w, x, y, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wxyy { get { return new Vector4(w, x, y, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wxyz { get { return new Vector4(w, x, y, z); } set { w= value.x; x = value.y; y = value.z; z = value.w; } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wxyw { get { return new Vector4(w, x, y, w); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wxzx { get { return new Vector4(w, x, z, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wxzy { get { return new Vector4(w, x, z, y); } set { w = value.x; x = value.y; z = value.z; y = value.w; } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wxzz { get { return new Vector4(w, x, z, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wxzw { get { return new Vector4(w, x, z, w); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wxwx { get { return new Vector4(w, x, w, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wxwy { get { return new Vector4(w, x, w, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wxwz { get { return new Vector4(w, x, w, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wxww { get { return new Vector4(w, x, w, w); } }

		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wyxx { get { return new Vector4(w, y, x, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wyxy { get { return new Vector4(w, y, x, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wyxz { get { return new Vector4(w, y, x, z); } set { w = value.x; y = value.y; x = value.z; z = value.w; } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wyxw { get { return new Vector4(w, y, x, w); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wyyx { get { return new Vector4(w, y, y, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wyyy { get { return new Vector4(w, y, y, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wyyz { get { return new Vector4(w, y, y, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wyyw { get { return new Vector4(w, y, y, w); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wyzx { get { return new Vector4(w, y, z, x); } set { w = value.x; y = value.y; z = value.z; x = value.w; } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wyzy { get { return new Vector4(w, y, z, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wyzz { get { return new Vector4(w, y, z, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wyzw { get { return new Vector4(w, y, z, w); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wywx { get { return new Vector4(w, y, w, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wywy { get { return new Vector4(w, y, w, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wywz { get { return new Vector4(w, y, w, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wyww { get { return new Vector4(w, y, w, w); } }

		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wzxx { get { return new Vector4(w, z, x, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wzxy { get { return new Vector4(w, z, x, y); } set { w = value.x; z = value.y; x = value.z; y = value.w; } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wzxz { get { return new Vector4(w, z, x, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wzxw { get { return new Vector4(w, z, x, w); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wzyx { get { return new Vector4(w, z, y, x); } set { w = value.x; z = value.y; y = value.z; x = value.w; } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wzyy { get { return new Vector4(w, z, y, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wzyz { get { return new Vector4(w, z, y, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wzyw { get { return new Vector4(w, z, y, w); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wzzx { get { return new Vector4(w, z, z, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wzzy { get { return new Vector4(w, z, z, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wzzz { get { return new Vector4(w, z, z, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wzzw { get { return new Vector4(w, z, z, w); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wzwx { get { return new Vector4(w, z, w, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wzwy { get { return new Vector4(w, z, w, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wzwz { get { return new Vector4(w, z, w, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wzww { get { return new Vector4(w, z, w, w); } }

		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wwxx { get { return new Vector4(w, w, x, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wwxy { get { return new Vector4(w, w, x, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wwxz { get { return new Vector4(w, w, x, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wwxw { get { return new Vector4(w, w, x, w); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wwyx { get { return new Vector4(w, w, y, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wwyy { get { return new Vector4(w, w, y, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wwyz { get { return new Vector4(w, w, y, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wwyw { get { return new Vector4(w, w, y, w); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wwzx { get { return new Vector4(w, w, z, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wwzy { get { return new Vector4(w, w, z, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wwzz { get { return new Vector4(w, w, z, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wwzw { get { return new Vector4(w, w, z, w); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wwwx { get { return new Vector4(w, w, w, x); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wwwy { get { return new Vector4(w, w, w, y); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wwwz { get { return new Vector4(w, w, w, z); } }
		/// <summary> <see cref="Vector4"/> Swizzle </summary>
		public Vector4 wwww { get { return new Vector4(w, w, w, w); } }
		#endregion
		#region Vector4 rgba swizzles
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rrrr { get { return new Vector4(r, r, r, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rrrg { get { return new Vector4(r, r, r, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rrrb { get { return new Vector4(r, r, r, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rrra { get { return new Vector4(r, r, r, a); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rrgr { get { return new Vector4(r, r, g, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rrgg { get { return new Vector4(r, r, g, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rrgb { get { return new Vector4(r, r, g, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rrga { get { return new Vector4(r, r, g, a); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rrbr { get { return new Vector4(r, r, b, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rrbg { get { return new Vector4(r, r, b, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rrbb { get { return new Vector4(r, r, b, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rrba { get { return new Vector4(r, r, b, a); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rrar { get { return new Vector4(r, r, a, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rrag { get { return new Vector4(r, r, a, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rrab { get { return new Vector4(r, r, a, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rraa { get { return new Vector4(r, r, a, a); } }

		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rgrr { get { return new Vector4(r, g, r, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rgrg { get { return new Vector4(r, g, r, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rgrb { get { return new Vector4(r, g, r, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rgra { get { return new Vector4(r, g, r, a); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rggr { get { return new Vector4(r, g, g, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rggg { get { return new Vector4(r, g, g, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rggb { get { return new Vector4(r, g, g, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rgga { get { return new Vector4(r, g, g, a); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rgbr { get { return new Vector4(r, g, b, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rgbg { get { return new Vector4(r, g, b, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rgbb { get { return new Vector4(r, g, b, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rgba { get { return new Vector4(r, g, b, a); } set { r = value.r; g = value.g; b = value.b; a = value.a; } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rgar { get { return new Vector4(r, g, a, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rgag { get { return new Vector4(r, g, a, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rgab { get { return new Vector4(r, g, a, b); } set { r = value.r; g = value.g; a = value.b; b = value.a; } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rgaa { get { return new Vector4(r, g, a, a); } }

		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rbrr { get { return new Vector4(r, b, r, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rbrg { get { return new Vector4(r, b, r, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rbrb { get { return new Vector4(r, b, r, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rbra { get { return new Vector4(r, b, r, a); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rbgr { get { return new Vector4(r, b, g, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rbgg { get { return new Vector4(r, b, g, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rbgb { get { return new Vector4(r, b, g, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rbga { get { return new Vector4(r, b, g, a); } set { r = value.r; b = value.g; g = value.b; a = value.a; } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rbbr { get { return new Vector4(r, b, b, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rbbg { get { return new Vector4(r, b, b, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rbbb { get { return new Vector4(r, b, b, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rbba { get { return new Vector4(r, b, b, a); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rbar { get { return new Vector4(r, b, a, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rbag { get { return new Vector4(r, b, a, g); } set { r = value.r; b = value.g; a = value.b; g = value.a; } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rbab { get { return new Vector4(r, b, a, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rbaa { get { return new Vector4(r, b, a, a); } }

		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rarr { get { return new Vector4(r, a, r, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rarg { get { return new Vector4(r, a, r, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rarb { get { return new Vector4(r, a, r, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rara { get { return new Vector4(r, a, r, a); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 ragr { get { return new Vector4(r, a, g, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 ragg { get { return new Vector4(r, a, g, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 ragb { get { return new Vector4(r, a, g, b); } set { r = value.r; a = value.g; g = value.b; b = value.a; } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 raga { get { return new Vector4(r, a, g, a); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rabr { get { return new Vector4(r, a, b, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rabg { get { return new Vector4(r, a, b, g); } set { r = value.r; a = value.g; b = value.b; g = value.a; } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 rabb { get { return new Vector4(r, a, b, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 raba { get { return new Vector4(r, a, b, a); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 raar { get { return new Vector4(r, a, a, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 raag { get { return new Vector4(r, a, a, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 raab { get { return new Vector4(r, a, a, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 raaa { get { return new Vector4(r, a, a, a); } }

		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 grrr { get { return new Vector4(g, r, r, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 grrg { get { return new Vector4(g, r, r, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 grrb { get { return new Vector4(g, r, r, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 grra { get { return new Vector4(g, r, r, a); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 grgr { get { return new Vector4(g, r, g, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 grgg { get { return new Vector4(g, r, g, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 grgb { get { return new Vector4(g, r, g, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 grga { get { return new Vector4(g, r, g, a); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 grbr { get { return new Vector4(g, r, b, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 grbg { get { return new Vector4(g, r, b, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 grbb { get { return new Vector4(g, r, b, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 grba { get { return new Vector4(g, r, b, a); } set { g = value.r; r = value.g; b = value.b; a = value.a; } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 grar { get { return new Vector4(g, r, a, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 grag { get { return new Vector4(g, r, a, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 grab { get { return new Vector4(g, r, a, b); } set { g = value.r; r = value.g; a = value.b; b = value.a; } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 graa { get { return new Vector4(g, r, a, a); } }

		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 ggrr { get { return new Vector4(g, g, r, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 ggrg { get { return new Vector4(g, g, r, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 ggrb { get { return new Vector4(g, g, r, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 ggra { get { return new Vector4(g, g, r, a); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 gggr { get { return new Vector4(g, g, g, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 gggg { get { return new Vector4(g, g, g, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 gggb { get { return new Vector4(g, g, g, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 ggga { get { return new Vector4(g, g, g, a); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 ggbr { get { return new Vector4(g, g, b, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 ggbg { get { return new Vector4(g, g, b, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 ggbb { get { return new Vector4(g, g, b, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 ggba { get { return new Vector4(g, g, b, a); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 ggar { get { return new Vector4(g, g, a, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 ggag { get { return new Vector4(g, g, a, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 ggab { get { return new Vector4(g, g, a, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 ggaa { get { return new Vector4(g, g, a, a); } }

		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 gbrr { get { return new Vector4(g, b, r, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 gbrg { get { return new Vector4(g, b, r, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 gbrb { get { return new Vector4(g, b, r, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 gbra { get { return new Vector4(g, b, r, a); } set { g = value.r; b = value.g; r = value.b; a = value.a; } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 gbgr { get { return new Vector4(g, b, g, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 gbgg { get { return new Vector4(g, b, g, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 gbgb { get { return new Vector4(g, b, g, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 gbga { get { return new Vector4(g, b, g, a); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 gbbr { get { return new Vector4(g, b, b, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 gbbg { get { return new Vector4(g, b, b, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 gbbb { get { return new Vector4(g, b, b, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 gbba { get { return new Vector4(g, b, b, a); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 gbar { get { return new Vector4(g, b, a, r); } set { g = value.r; b = value.g; a = value.b; r = value.a; } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 gbag { get { return new Vector4(g, b, a, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 gbab { get { return new Vector4(g, b, a, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 gbaa { get { return new Vector4(g, b, a, a); } }

		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 garr { get { return new Vector4(g, a, r, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 garg { get { return new Vector4(g, a, r, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 garb { get { return new Vector4(g, a, r, b); } set { g = value.r; a = value.g; r = value.b; b = value.a; } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 gara { get { return new Vector4(g, a, r, a); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 gagr { get { return new Vector4(g, a, g, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 gagg { get { return new Vector4(g, a, g, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 gagb { get { return new Vector4(g, a, g, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 gaga { get { return new Vector4(g, a, g, a); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 gabr { get { return new Vector4(g, a, b, r); } set { g = value.r; a = value.g; b = value.b; r = value.a; } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 gabg { get { return new Vector4(g, a, b, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 gabb { get { return new Vector4(g, a, b, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 gaba { get { return new Vector4(g, a, b, a); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 gaar { get { return new Vector4(g, a, a, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 gaag { get { return new Vector4(g, a, a, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 gaab { get { return new Vector4(g, a, a, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 gaaa { get { return new Vector4(g, a, a, a); } }

		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 brrr { get { return new Vector4(b, r, r, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 brrg { get { return new Vector4(b, r, r, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 brrb { get { return new Vector4(b, r, r, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 brra { get { return new Vector4(b, r, r, a); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 brgr { get { return new Vector4(b, r, g, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 brgg { get { return new Vector4(b, r, g, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 brgb { get { return new Vector4(b, r, g, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 brga { get { return new Vector4(b, r, g, a); } set { b = value.r; r = value.g; g = value.b; a = value.a; } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 brbr { get { return new Vector4(b, r, b, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 brbg { get { return new Vector4(b, r, b, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 brbb { get { return new Vector4(b, r, b, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 brba { get { return new Vector4(b, r, b, a); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 brar { get { return new Vector4(b, r, a, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 brag { get { return new Vector4(b, r, a, g); } set { b = value.r; r = value.g; a = value.b; g = value.a; } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 brab { get { return new Vector4(b, r, a, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 braa { get { return new Vector4(b, r, a, a); } }

		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 bgrr { get { return new Vector4(b, g, r, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 bgrg { get { return new Vector4(b, g, r, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 bgrb { get { return new Vector4(b, g, r, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 bgra { get { return new Vector4(b, g, r, a); } set { b = value.r; g = value.g; r = value.b; a = value.a; } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 bggr { get { return new Vector4(b, g, g, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 bggg { get { return new Vector4(b, g, g, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 bggb { get { return new Vector4(b, g, g, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 bgga { get { return new Vector4(b, g, g, a); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 bgbr { get { return new Vector4(b, g, b, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 bgbg { get { return new Vector4(b, g, b, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 bgbb { get { return new Vector4(b, g, b, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 bgba { get { return new Vector4(b, g, b, a); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 bgar { get { return new Vector4(b, g, a, r); } set { b = value.r; g = value.g; a = value.b; r = value.a; } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 bgag { get { return new Vector4(b, g, a, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 bgab { get { return new Vector4(b, g, a, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 bgaa { get { return new Vector4(b, g, a, a); } }

		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 bbrr { get { return new Vector4(b, b, r, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 bbrg { get { return new Vector4(b, b, r, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 bbrb { get { return new Vector4(b, b, r, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 bbra { get { return new Vector4(b, b, r, a); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 bbgr { get { return new Vector4(b, b, g, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 bbgg { get { return new Vector4(b, b, g, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 bbgb { get { return new Vector4(b, b, g, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 bbga { get { return new Vector4(b, b, g, a); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 bbbr { get { return new Vector4(b, b, b, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 bbbg { get { return new Vector4(b, b, b, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 bbbb { get { return new Vector4(b, b, b, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 bbba { get { return new Vector4(b, b, b, a); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 bbar { get { return new Vector4(b, b, a, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 bbag { get { return new Vector4(b, b, a, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 bbab { get { return new Vector4(b, b, a, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 bbaa { get { return new Vector4(b, b, a, a); } }

		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 barr { get { return new Vector4(b, a, r, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 barg { get { return new Vector4(b, a, r, g); } set { b = value.r; a = value.g; r = value.b; g = value.a; } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 barb { get { return new Vector4(b, a, r, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 bara { get { return new Vector4(b, a, r, a); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 bagr { get { return new Vector4(b, a, g, r); } set { b = value.r; a = value.g; g = value.b; r = value.a; } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 bagg { get { return new Vector4(b, a, g, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 bagb { get { return new Vector4(b, a, g, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 baga { get { return new Vector4(b, a, g, a); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 babr { get { return new Vector4(b, a, b, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 babg { get { return new Vector4(b, a, b, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 babb { get { return new Vector4(b, a, b, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 baba { get { return new Vector4(b, a, b, a); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 baar { get { return new Vector4(b, a, a, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 baag { get { return new Vector4(b, a, a, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 baab { get { return new Vector4(b, a, a, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 baaa { get { return new Vector4(b, a, a, a); } }

		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 arrr { get { return new Vector4(a, r, r, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 arrg { get { return new Vector4(a, r, r, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 arrb { get { return new Vector4(a, r, r, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 arra { get { return new Vector4(a, r, r, a); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 argr { get { return new Vector4(a, r, g, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 argg { get { return new Vector4(a, r, g, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 argb { get { return new Vector4(a, r, g, b); } set { a = value.r; r = value.g; g = value.b; b = value.a; } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 arga { get { return new Vector4(a, r, g, a); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 arbr { get { return new Vector4(a, r, b, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 arbg { get { return new Vector4(a, r, b, g); } set { a = value.r; r = value.g; b = value.b; g = value.a; } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 arbb { get { return new Vector4(a, r, b, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 arba { get { return new Vector4(a, r, b, a); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 arar { get { return new Vector4(a, r, a, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 arag { get { return new Vector4(a, r, a, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 arab { get { return new Vector4(a, r, a, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 araa { get { return new Vector4(a, r, a, a); } }

		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 agrr { get { return new Vector4(a, g, r, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 agrg { get { return new Vector4(a, g, r, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 agrb { get { return new Vector4(a, g, r, b); } set { a = value.r; g = value.g; r = value.b; b = value.a; } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 agra { get { return new Vector4(a, g, r, a); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 aggr { get { return new Vector4(a, g, g, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 aggg { get { return new Vector4(a, g, g, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 aggb { get { return new Vector4(a, g, g, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 agga { get { return new Vector4(a, g, g, a); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 agbr { get { return new Vector4(a, g, b, r); } set { a = value.r; g = value.g; b = value.b; r = value.a; } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 agbg { get { return new Vector4(a, g, b, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 agbb { get { return new Vector4(a, g, b, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 agba { get { return new Vector4(a, g, b, a); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 agar { get { return new Vector4(a, g, a, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 agag { get { return new Vector4(a, g, a, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 agab { get { return new Vector4(a, g, a, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 agaa { get { return new Vector4(a, g, a, a); } }

		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 abrr { get { return new Vector4(a, b, r, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 abrg { get { return new Vector4(a, b, r, g); } set { a = value.r; b = value.g; r = value.b; g = value.a; } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 abrb { get { return new Vector4(a, b, r, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 abra { get { return new Vector4(a, b, r, a); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 abgr { get { return new Vector4(a, b, g, r); } set { a = value.r; b = value.g; g = value.b; r = value.a; } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 abgg { get { return new Vector4(a, b, g, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 abgb { get { return new Vector4(a, b, g, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 abga { get { return new Vector4(a, b, g, a); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 abbr { get { return new Vector4(a, b, b, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 abbg { get { return new Vector4(a, b, b, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 abbb { get { return new Vector4(a, b, b, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 abba { get { return new Vector4(a, b, b, a); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 abar { get { return new Vector4(a, b, a, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 abag { get { return new Vector4(a, b, a, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 abab { get { return new Vector4(a, b, a, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 abaa { get { return new Vector4(a, b, a, a); } }

		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 aarr { get { return new Vector4(a, a, r, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 aarg { get { return new Vector4(a, a, r, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 aarb { get { return new Vector4(a, a, r, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 aara { get { return new Vector4(a, a, r, a); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 aagr { get { return new Vector4(a, a, g, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 aagg { get { return new Vector4(a, a, g, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 aagb { get { return new Vector4(a, a, g, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 aaga { get { return new Vector4(a, a, g, a); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 aabr { get { return new Vector4(a, a, b, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 aabg { get { return new Vector4(a, a, b, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 aabb { get { return new Vector4(a, a, b, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 aaba { get { return new Vector4(a, a, b, a); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 aaar { get { return new Vector4(a, a, a, r); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 aaag { get { return new Vector4(a, a, a, g); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 aaab { get { return new Vector4(a, a, a, b); } }
		/// <summary> <see cref="Vector4"/> swizzle </summary>
		public Vector4 aaaa { get { return new Vector4(a, a, a, a); } }
		#endregion

		#region Vector3 swizzles
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 xxx { get { return new Vector3(x, x, x); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 xxy { get { return new Vector3(x, x, y); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 xxz { get { return new Vector3(x, x, z); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 xxw { get { return new Vector3(x, x, z); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 xyx { get { return new Vector3(x, y, x); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 xyy { get { return new Vector3(x, y, y); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 xyz { get { return new Vector3(x, y, z); } set { x = value.x; y = value.y; z = value.z; } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 xyw { get { return new Vector3(x, y, z); } set { x = value.x; y = value.y; w = value.z; } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 xzx { get { return new Vector3(x, z, x); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 xzy { get { return new Vector3(x, z, y); } set { x = value.x; z = value.y; y = value.z; } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 xzz { get { return new Vector3(x, z, z); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 xzw { get { return new Vector3(x, z, z); } set { x = value.x; z = value.y; w = value.z; } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 xwx { get { return new Vector3(x, w, x); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 xwy { get { return new Vector3(x, w, y); } set { x = value.x; w = value.y; y = value.z; } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 xwz { get { return new Vector3(x, w, z); } set { x = value.x; w = value.y; z = value.z; } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 xww { get { return new Vector3(x, w, z); } }

		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 yxx { get { return new Vector3(x, x, x); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 yxy { get { return new Vector3(x, x, y); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 yxz { get { return new Vector3(x, x, z); } set { y = value.x; x = value.y; z = value.z; } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 yxw { get { return new Vector3(x, x, z); } set { y = value.x; x = value.y; w = value.z; } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 yyx { get { return new Vector3(x, y, x); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 yyy { get { return new Vector3(x, y, y); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 yyz { get { return new Vector3(x, y, z); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 yyw { get { return new Vector3(x, y, z); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 yzx { get { return new Vector3(x, z, x); } set { y = value.x; z = value.y; x = value.z; } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 yzy { get { return new Vector3(x, z, y); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 yzz { get { return new Vector3(x, z, z); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 yzw { get { return new Vector3(x, z, z); } set { y = value.x; z = value.y; w = value.z; } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 ywx { get { return new Vector3(x, w, x); } set { y = value.x; w = value.y; x = value.z; } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 ywy { get { return new Vector3(x, w, y); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 ywz { get { return new Vector3(x, w, z); } set { y = value.x; w = value.y; z = value.z; } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 yww { get { return new Vector3(x, w, z); } }

		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 zxx { get { return new Vector3(x, x, x); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 zxy { get { return new Vector3(x, x, y); } set { z = value.x; x = value.y; y = value.z; } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 zxz { get { return new Vector3(x, x, z); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 zxw { get { return new Vector3(x, x, z); } set { z = value.x; x = value.y; w = value.z; } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 zyx { get { return new Vector3(x, y, x); } set { z = value.x; y = value.y; x = value.z; } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 zyy { get { return new Vector3(x, y, y); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 zyz { get { return new Vector3(x, y, z); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 zyw { get { return new Vector3(x, y, z); } set { z = value.x; y = value.y; w = value.z; } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 zzx { get { return new Vector3(x, z, x); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 zzy { get { return new Vector3(x, z, y); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 zzz { get { return new Vector3(x, z, z); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 zzw { get { return new Vector3(x, z, z); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 zwx { get { return new Vector3(x, w, x); } set { z = value.x; w = value.y; x = value.z; } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 zwy { get { return new Vector3(x, w, y); } set { z = value.x; w = value.y; y = value.z; } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 zwz { get { return new Vector3(x, w, z); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 zww { get { return new Vector3(x, w, z); } }

		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 wxx { get { return new Vector3(x, x, x); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 wxy { get { return new Vector3(x, x, y); } set { w = value.x; x = value.y; y = value.z; } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 wxz { get { return new Vector3(x, x, z); } set { w = value.x; x = value.y; z = value.z; } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 wxw { get { return new Vector3(x, x, z); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 wyx { get { return new Vector3(x, y, x); } set { w = value.x; y = value.y; x = value.z; } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 wyy { get { return new Vector3(x, y, y); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 wyz { get { return new Vector3(x, y, z); } set { w = value.x; y = value.y; z = value.z; } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 wyw { get { return new Vector3(x, y, z); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 wzx { get { return new Vector3(x, z, x); } set { w = value.x; z = value.y; x = value.z; } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 wzy { get { return new Vector3(x, z, y); } set { w = value.x; z = value.y; y = value.z; } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 wzz { get { return new Vector3(x, z, z); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 wzw { get { return new Vector3(x, z, z); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 wwx { get { return new Vector3(x, w, x); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 wwy { get { return new Vector3(x, w, y); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 wwz { get { return new Vector3(x, w, z); } }
		/// <summary> <see cref="Vector3"/> Swizzle </summary>
		public Vector3 www { get { return new Vector3(x, w, z); } }
		#endregion
		#region Vector3 rgba swizzles
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 rrr { get { return new Vector3(r, r, r); } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 rrg { get { return new Vector3(r, r, g); } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 rrb { get { return new Vector3(r, r, b); } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 rra { get { return new Vector3(r, r, b); } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 rgr { get { return new Vector3(r, g, r); } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 rgg { get { return new Vector3(r, g, g); } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 rgb { get { return new Vector3(r, g, b); } set { r = value.r; g = value.g; b = value.b; } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 rga { get { return new Vector3(r, g, b); } set { r = value.r; g = value.g; a = value.b; } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 rbr { get { return new Vector3(r, b, r); } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 rbg { get { return new Vector3(r, b, g); } set { r = value.r; b = value.g; g = value.b; } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 rbb { get { return new Vector3(r, b, b); } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 rba { get { return new Vector3(r, b, b); } set { r = value.r; b = value.g; a = value.b; } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 rar { get { return new Vector3(r, a, r); } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 rag { get { return new Vector3(r, a, g); } set { r = value.r; a = value.g; g = value.b; } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 rab { get { return new Vector3(r, a, b); } set { r = value.r; a = value.g; b = value.b; } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 raa { get { return new Vector3(r, a, b); } }

		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 grr { get { return new Vector3(r, r, r); } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 grg { get { return new Vector3(r, r, g); } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 grb { get { return new Vector3(r, r, b); } set { g = value.r; r = value.g; b = value.b; } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 gra { get { return new Vector3(r, r, b); } set { g = value.r; r = value.g; a = value.b; } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 ggr { get { return new Vector3(r, g, r); } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 ggg { get { return new Vector3(r, g, g); } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 ggb { get { return new Vector3(r, g, b); } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 gga { get { return new Vector3(r, g, b); } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 gbr { get { return new Vector3(r, b, r); } set { g = value.r; b = value.g; r = value.b; } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 gbg { get { return new Vector3(r, b, g); } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 gbb { get { return new Vector3(r, b, b); } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 gba { get { return new Vector3(r, b, b); } set { g = value.r; b = value.g; a = value.b; } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 gar { get { return new Vector3(r, a, r); } set { g = value.r; a = value.g; r = value.b; } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 gag { get { return new Vector3(r, a, g); } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 gab { get { return new Vector3(r, a, b); } set { g = value.r; a = value.g; b = value.b; } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 gaa { get { return new Vector3(r, a, b); } }

		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 brr { get { return new Vector3(r, r, r); } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 brg { get { return new Vector3(r, r, g); } set { b = value.r; r = value.g; g = value.b; } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 brb { get { return new Vector3(r, r, b); } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 bra { get { return new Vector3(r, r, b); } set { b = value.r; r = value.g; a = value.b; } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 bgr { get { return new Vector3(r, g, r); } set { b = value.r; g = value.g; r = value.b; } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 bgg { get { return new Vector3(r, g, g); } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 bgb { get { return new Vector3(r, g, b); } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 bga { get { return new Vector3(r, g, b); } set { b = value.r; g = value.g; a = value.b; } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 bbr { get { return new Vector3(r, b, r); } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 bbg { get { return new Vector3(r, b, g); } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 bbb { get { return new Vector3(r, b, b); } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 bba { get { return new Vector3(r, b, b); } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 bar { get { return new Vector3(r, a, r); } set { b = value.r; a = value.g; r = value.b; } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 bag { get { return new Vector3(r, a, g); } set { b = value.r; a = value.g; g = value.b; } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 bab { get { return new Vector3(r, a, b); } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 baa { get { return new Vector3(r, a, b); } }

		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 arr { get { return new Vector3(r, r, r); } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 arg { get { return new Vector3(r, r, g); } set { a = value.r; r = value.g; g = value.b; } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 arb { get { return new Vector3(r, r, b); } set { a = value.r; r = value.g; b = value.b; } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 ara { get { return new Vector3(r, r, b); } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 agr { get { return new Vector3(r, g, r); } set { a = value.r; g = value.g; r = value.b; } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 agg { get { return new Vector3(r, g, g); } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 agb { get { return new Vector3(r, g, b); } set { a = value.r; g = value.g; b = value.b; } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 aga { get { return new Vector3(r, g, b); } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 abr { get { return new Vector3(r, b, r); } set { a = value.r; b = value.g; r = value.b; } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 abg { get { return new Vector3(r, b, g); } set { a = value.r; b = value.g; g = value.b; } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 abb { get { return new Vector3(r, b, b); } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 aba { get { return new Vector3(r, b, b); } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 aar { get { return new Vector3(r, a, r); } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 aag { get { return new Vector3(r, a, g); } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 aab { get { return new Vector3(r, a, b); } }
		/// <summary> <see cref="Vector3"/> swizzle </summary>
		public Vector3 aaa { get { return new Vector3(r, a, b); } }
		#endregion

		#region Vector2 swizzles
		/// <summary> <see cref="Vector2"/> swizzle </summary>
		public Vector2 xx { get { return new Vector2(x, x); } }
		/// <summary> <see cref="Vector2"/> swizzle </summary>
		public Vector2 xy { get { return new Vector2(x, y); } set { x = value.x; y = value.y; } }
		/// <summary> <see cref="Vector2"/> swizzle </summary>
		public Vector2 xz { get { return new Vector2(x, z); } set { x = value.x; z = value.y; } }
		/// <summary> <see cref="Vector2"/> swizzle </summary>
		public Vector2 xw { get { return new Vector2(x, w); } set { x = value.x; w = value.y; } }
		/// <summary> <see cref="Vector2"/> swizzle </summary>
		public Vector2 yx { get { return new Vector2(y, x); } set { y = value.x; x = value.y; } }
		/// <summary> <see cref="Vector2"/> swizzle </summary>
		public Vector2 yy { get { return new Vector2(y, y); } }
		/// <summary> <see cref="Vector2"/> swizzle </summary>
		public Vector2 yz { get { return new Vector2(y, z); } set { y = value.x; z = value.y; } }
		/// <summary> <see cref="Vector2"/> swizzle </summary>
		public Vector2 yw { get { return new Vector2(y, w); } set { y = value.x; w = value.y; } }
		/// <summary> <see cref="Vector2"/> swizzle </summary>
		public Vector2 zx { get { return new Vector2(z, x); } set { z = value.x; x = value.y; } }
		/// <summary> <see cref="Vector2"/> swizzle </summary>
		public Vector2 zy { get { return new Vector2(z, y); } set { z = value.x; y = value.y; } }
		/// <summary> <see cref="Vector2"/> swizzle </summary>
		public Vector2 zz { get { return new Vector2(z, z); } }
		/// <summary> <see cref="Vector2"/> swizzle </summary>
		public Vector2 zw { get { return new Vector2(z, w); } set { z = value.x; w = value.y; } }
		/// <summary> <see cref="Vector2"/> swizzle </summary>
		public Vector2 wx { get { return new Vector2(w, x); } set { w = value.x; x = value.y; } }
		/// <summary> <see cref="Vector2"/> swizzle </summary>
		public Vector2 wy { get { return new Vector2(w, y); } set { w = value.x; y = value.y; } }
		/// <summary> <see cref="Vector2"/> swizzle </summary>
		public Vector2 wz { get { return new Vector2(w, z); } set { w = value.x; z = value.y; } }
		/// <summary> <see cref="Vector2"/> swizzle </summary>
		public Vector2 ww { get { return new Vector2(w, w); } }
		#endregion
		#region Vector2 rgb swizzles
		/// <summary> <see cref="Vector2"/> swizzle </summary>
		public Vector2 rr { get { return new Vector2(r, r); } }
		/// <summary> <see cref="Vector2"/> swizzle </summary>
		public Vector2 rg { get { return new Vector2(r, g); } set { r = value.r; g = value.g; } }
		/// <summary> <see cref="Vector2"/> swizzle </summary>
		public Vector2 rb { get { return new Vector2(r, b); } set { r = value.r; b = value.g; } }
		/// <summary> <see cref="Vector2"/> swizzle </summary>
		public Vector2 ra { get { return new Vector2(r, a); } set { r = value.r; a = value.g; } }
		/// <summary> <see cref="Vector2"/> swizzle </summary>
		public Vector2 gr { get { return new Vector2(g, r); } set { g = value.r; r = value.g; } }
		/// <summary> <see cref="Vector2"/> swizzle </summary>
		public Vector2 gg { get { return new Vector2(g, g); } }
		/// <summary> <see cref="Vector2"/> swizzle </summary>
		public Vector2 gb { get { return new Vector2(g, b); } set { g = value.r; b = value.g; } }
		/// <summary> <see cref="Vector2"/> swizzle </summary>
		public Vector2 ga { get { return new Vector2(g, a); } set { g = value.r; a = value.g; } }
		/// <summary> <see cref="Vector2"/> swizzle </summary>
		public Vector2 br { get { return new Vector2(b, r); } set { b = value.r; r = value.g; } }
		/// <summary> <see cref="Vector2"/> swizzle </summary>
		public Vector2 bg { get { return new Vector2(b, g); } set { b = value.r; g = value.g; } }
		/// <summary> <see cref="Vector2"/> swizzle </summary>
		public Vector2 bb { get { return new Vector2(b, b); } }
		/// <summary> <see cref="Vector2"/> swizzle </summary>
		public Vector2 ba { get { return new Vector2(b, a); } set { b = value.r; a = value.g; } }
		/// <summary> <see cref="Vector2"/> swizzle </summary>
		public Vector2 ar { get { return new Vector2(a, r); } set { a = value.r; r = value.g; } }
		/// <summary> <see cref="Vector2"/> swizzle </summary>
		public Vector2 ag { get { return new Vector2(a, g); } set { a = value.r; g = value.g; } }
		/// <summary> <see cref="Vector2"/> swizzle </summary>
		public Vector2 ab { get { return new Vector2(a, b); } set { a = value.r; b = value.g; } }
		/// <summary> <see cref="Vector2"/> swizzle </summary>
		public Vector2 aa { get { return new Vector2(a, a); } }
		#endregion

		/// <summary> Get a <see cref="Vector4"/> in the same direction, with a length of 1. </summary>
		public Vector4 normalized { get { float m = magnitude; if (m > EPSILON) { return this / m; } return zero; } }
		/// <summary> Length by distance formula </summary>
		public float magnitude { get { return Sqrt(x * x + y * y + z * z + w * w); } }
		/// <summary> Squared length by partial distance formula. Slightly faster for comparisons due to skipping the <see cref="Sqrt(float)"/> </summary>
		public float sqrMagnitude { get { return x * x + y * y + z * z + w * w; } }

		/// <summary> Set each component of this <see cref="Vector4"/>. Modifies the <see cref="Vector4"/> this is called on. </summary>
		public void Set(float a, float b, float c, float d) { x = a; y = b; z = c; w = d; }
		/// <summary> Sets this <see cref="Vector4"/>'s length to 1. Modifies the <see cref="Vector4"/> this is called on. </summary>
		public void Normalize() { float m = magnitude; if (m > EPSILON) { this /= m; } else { this = zero; } }
		/// <summary> Scales the <see cref="Vector4"/> component-wise by the given vector. Modifies the <see cref="Vector4"/> this is called on. </summary>
		public void Scale(Vector4 s) { x *= s.x; y *= s.y; z *= s.z; w *= s.w; }
		/// <summary> Clamps the <see cref="Vector4"/> between two other <see cref="Vector4"/>s. Modifies the <see cref="Vector4"/> this is called on. </summary>
		public void Clamp(Vector4 min, Vector4 max) {
			x = Mathf.Clamp(x, min.x, max.x);
			y = Mathf.Clamp(y, min.y, max.y);
			z = Mathf.Clamp(z, min.z, max.z);
			w = Mathf.Clamp(w, min.w, max.w);
		}

		/// <summary> Get component-wise absolute value of this <see cref="Vector4"/>. </summary>
		public Vector4 Abs() { return new Vector4(Mathf.Abs(x), Mathf.Abs(y), Mathf.Abs(z), Mathf.Abs(w)); }

		/// <summary> Get component-wise absolute value of given <see cref="Vector4"/>. </summary>
		public static Vector4 Abs(Vector4 v) { return new Vector4(Mathf.Abs(v.x), Mathf.Abs(v.y), Mathf.Abs(v.z), Mathf.Abs(v.w)); }

		/// <summary> Componentwise minimum of two <see cref="Vector4"/>s. </summary>
		public static Vector4 Min(Vector4 a, Vector4 b) { return new Vector4(Mathf.Min(a.x, b.x), Mathf.Min(a.y, b.y), Mathf.Min(a.z, b.z), Mathf.Min(a.w, b.w)); }
		/// <summary> Componentwise maximum of two <see cref="Vector4"/>s. </summary>
		public static Vector4 Max(Vector4 a, Vector4 b) { return new Vector4(Mathf.Max(a.x, b.x), Mathf.Max(a.y, b.y), Mathf.Max(a.z, b.z), Mathf.Max(a.w, b.w)); }

		/// <summary> Dot product between two <see cref="Vector4"/>s . </summary>
		public static float Dot(Vector4 a, Vector4 b) { return a.x * b.x + a.y * b.y + a.z * b.z + a.w * b.w; }
		/// <summary> Reflect a <paramref name="dir"/>ection <see cref="Vector4"/> over the given <paramref name="normal"/>. </summary>
		public static Vector4 Reflect(Vector4 dir, Vector4 normal) { return -2f * Dot(normal, dir) * normal + dir; }
		/// <summary> Project a <paramref name="dir"/>ection <see cref="Vector4"/> along the given <paramref name="normal"/>. </summary>
		public static Vector4 Project(Vector4 dir, Vector4 normal) {
			float len = Dot(normal, normal);
			return (len < SQR_EPSILON) ? zero : normal * Dot(dir, normal) / len;
		}

		/// <summary> Get the distance between two <see cref="Vector4"/>s </summary>
		public static float Distance(Vector4 a, Vector4 b) {
			Vector4 v = new Vector4(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
			return Sqrt(v.x * v.x + v.y * v.y + v.z * v.z + v.w * v.w);
		}
		/// <summary> Get a <see cref="Vector4"/> in the same direction as the given <paramref name="vector"/>, but at maximum <paramref name="maxLength"/> units long. </summary>
		public static Vector4 ClampMagnitude(Vector4 vector, float maxLength) {
			return (vector.sqrMagnitude > maxLength * maxLength) ? vector.normalized * maxLength : vector;
		}

		/// <summary> Linearly interpolate between two <see cref="Vector4"/>s by proportion <paramref name="f"/>. </summary>
		public static Vector4 Lerp(Vector4 a, Vector4 b, float f) {
			f = Clamp01(f);
			return new Vector4(a.x + (b.x - a.x) * f, a.y + (b.y - a.y) * f, a.z + (b.z - a.z) * f, a.w + (b.w - a.w) * f);
		}
		/// <summary> Linearly interpolate between two <see cref="Vector4"/>s by proportion <paramref name="f"/>, without a <see cref="Mathf.Clamp01(float)"/>. </summary>
		public static Vector4 LerpUnclamped(Vector4 a, Vector4 b, float f) {
			return new Vector4(a.x + (b.x - a.x) * f, a.y + (b.y - a.y) * f, a.z + (b.z - a.z) * f, a.w + (b.w - a.w) * f);
		}
		/// <summary> Move <paramref name="current"/> towards <paramref name="target"/>, at most changing its length by <paramref name="maxDistanceDelta"/> units. </summary>
		public static Vector4 MoveTowards(Vector4 current, Vector4 target, float maxDistanceDelta) {
			Vector4 a = target - current;
			float m = a.magnitude;
			return (m < maxDistanceDelta || m == 0f) ? target : (current + a / m * maxDistanceDelta);
		}

		/// <summary> Negate each component of the given <see cref="Vector4"/> </summary>
		public static Vector4 operator -(Vector4 a) { return new Vector4(-a.x, -a.y, -a.z, -a.w); }
		/// <summary> Add two <see cref="Vector4"/>s together </summary>
		public static Vector4 operator +(Vector4 a, Vector4 b) { return new Vector4(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w); }
		/// <summary> Subtract one <see cref="Vector4"/> from another </summary>
		public static Vector4 operator -(Vector4 a, Vector4 b) { return new Vector4(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w); }
		/// <summary> Multiply two <see cref="Vector4"/>s together  </summary>
		public static Vector4 operator *(Vector4 a, Vector4 b) { return new Vector4(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w); }
		/// <summary> Divide one <see cref="Vector4"/> from another  </summary>
		public static Vector4 operator /(Vector4 a, Vector4 b) { return new Vector4(a.x / b.x, a.y / b.y, a.z / b.z, a.w / b.w); }
		/// <summary> Multiply a <see cref="Vector4"/> by a scalar </summary>
		public static Vector4 operator *(Vector4 a, float f) { return new Vector4(a.x * f, a.y * f, a.z * f, a.w * f); }
		/// <summary> Multiply a <see cref="Vector4"/> by a scalar </summary>
		public static Vector4 operator *(float f, Vector4 a) { return new Vector4(a.x * f, a.y * f, a.z * f, a.w * f); }
		/// <summary> Divide a <see cref="Vector4"/> by a scalar </summary>
		public static Vector4 operator /(Vector4 a, float f) { return new Vector4(a.x / f, a.y / f, a.z / f, a.w / f); }
		/// <summary> Inverse divide a <see cref="Vector4"/> by a scalar </summary>
		public static Vector4 operator /(float f, Vector4 a) { return new Vector4(f / a.x, f / a.y, f / a.z, f / a.w); }

		/// <summary> Compare two <see cref="Vector4"/>s by their square distance being below <see cref="COMPARE_EPSILON"/>. </summary>
		public static bool operator ==(Vector4 a, Vector4 b) { return (a - b).sqrMagnitude <= COMPARE_EPSILON; }
		/// <summary> Inverse compare two <see cref="Vector4"/>s by their square distance being below <see cref="COMPARE_EPSILON"/>. </summary>
		public static bool operator !=(Vector4 a, Vector4 b) { return !(a == b); }

		/// <summary> Automatically promote a <see cref="Vector3"/> to a <see cref="Vector4"/> </summary>
		public static implicit operator Vector4(Vector3 v) { return new Vector4(v.x, v.y, v.z, 0f); }
		/// <summary> Explicitly demote a <see cref="Vector4"/> to a <see cref="Vector3"/> </summary>
		public static explicit operator Vector3(Vector4 v) { return new Vector3(v.x, v.y, v.z); }

		/// <summary> Automatically promote a <see cref="Vector2"/> to a <see cref="Vector4"/> </summary>
		public static implicit operator Vector4(Vector2 v) { return new Vector4(v.x, v.y, 0f, 0f); }
		/// <summary> Explicitly demote a <see cref="Vector4"/> to a <see cref="Vector2"/> </summary>
		public static implicit operator Vector2(Vector4 v) { return new Vector2(v.x, v.y); }

	}
	#endregion
	#region Rect
	/// <summary> Class similar to UnityEngine.Rect. Stores four <see cref="float"/>s, like a <see cref="Vector4"/>, but interprets them as a Rectangle. (x,y) x (width, height) </summary>
	[System.Serializable]
	public struct Rect : IEquatable<Rect> {
		/// <summary> Zero rectangle. (0,0) x (0,0) </summary>
		public static Rect zero { get { return new Rect(0, 0, 0, 0); } }
		/// <summary> Unit rectangle. (0,0) x (1,1) </summary>
		public static Rect unit { get { return new Rect(0, 0, 1f, 1f); } }

		/// <summary> Position information </summary>
		public float x, y;
		/// <summary> Size information </summary>
		public float width, height;
		/// <summary> Construct a <see cref="Rect"/> with the given location and size </summary>
		public Rect(float x, float y, float width, float height) { this.x = x; this.y = y; this.width = width; this.height = height; }
		/// <summary> Construct a <see cref="Rect"/> with the given location and size </summary>
		public Rect(Vector2 pos, Vector2 size) { x = pos.x; y = pos.y; width = size.x; height = size.y; }
		/// <summary> Copy a <see cref="Rect"/> into another. </summary>
		public Rect(Rect source) { x = source.x; y = source.y; width = source.width; height = source.height; }

		/// <summary> get/set the top-left position of this <see cref="Rect"/> as a <see cref="Vector2"/>. </summary>
		public Vector2 position {
			get { return new Vector2(x, y); }
			set { x = value.x; y = value.y; }
		}
		/// <summary> get/set the center position of this <see cref="Rect"/> as a <see cref="Vector2"/>. </summary>
		public Vector2 center {
			get { return new Vector2(x + width / 2f, y + height / 2f); }
			set { x = value.x - width / 2f; y = value.y - height / 2f; }
		}
		/// <summary> get/setthe minimum position of this <see cref="Rect"/> as a <see cref="Vector2"/> </summary>
		public Vector2 min {
			get { return new Vector2(x, y); }
			set { x = value.x; y = value.y; }
		}
		/// <summary> get/set  the maximum position of this <see cref="Rect"/> as a <see cref="Vector2"/> </summary>
		public Vector2 max {
			get { return new Vector2(x + width, y + height); }
			set { Vector2 size = value - min; width = size.x; height = size.y; }
		}
		
		/// <summary> get/set the size of this <see cref="Rect"/> as a <see cref="Vector2"/> </summary>
		public Vector2 size {
			get { return new Vector2(width, height); }
			set { width = value.x; height = value.y; }
		}
		/// <summary> get/set the lowest x-coord in this <see cref="Rect"/>. </summary>
		public float xMin { get { return x; } set { float xm = xMax; x = value; width = xm - x; } }
		/// <summary> get/set the lowest y-coord in this <see cref="Rect"/>. </summary>
		public float yMin { get { return y; } set { float ym = yMax; y = value; height = ym - y; } }
		/// <summary> get/set the highest x-coord in this <see cref="Rect"/>. </summary>
		public float xMax { get { return x + width; } set { width = value - x; } }
		/// <summary> get/set the highest y-coord in this <see cref="Rect"/>. </summary>
		public float yMax { get { return y + height; } set { height = value - y; } }

		/// <summary> get the left edge of this <see cref="Rect"/>. </summary>
		public float left { get { return x; } }
		/// <summary> get the right edge of this <see cref="Rect"/>. </summary>
		public float right { get { return x + width; } }
		/// <summary> get the top edge of this <see cref="Rect"/>. </summary>
		public float top { get { return y; } }
		/// <summary> get the bottom edge of this <see cref="Rect"/>. </summary>
		public float bottom { get { return y + height; } }


		/// <inheritdoc />
		public override bool Equals(object other) { return other is Rect && this.Equals((Rect)other); }
		/// <summary> Compare two <see cref="Rect"/>s by their position and size for equality. </summary>
		public bool Equals(Rect other) { return x.Equals(other.x) && y.Equals(other.y) && width.Equals(other.width) && height.Equals(other.height); }
		/// <inheritdoc />
		public override string ToString() { return $"(x:{x:F2}, y:{y:F2}, width:{width:F2}, height:{height:F2})"; }
		/// <inheritdoc />
		public override int GetHashCode() { return x.GetHashCode() ^ (width.GetHashCode() << 2) ^ (y.GetHashCode() >> 2) ^ (height.GetHashCode() >> 1); }

		/// <summary> Directly set the position and size of this <see cref="Rect"/>. </summary>
		public void Set(float x, float y, float width, float height) {
			this.x = x; this.y = y; this.width = width; this.height = height;
		}
		/// <summary> Does this <see cref="Rect"/> contain the given <paramref name="point"/>? </summary>
		public bool Contains(Vector2 point) {
			return point.x >= xMin && point.x <= xMax && point.y >= yMin && point.y <= yMax;
		}
		/// <summary> Does this <see cref="Rect"/> contain the given <paramref name="point"/>? </summary>
		public bool Contains(Vector3 point) {
			return point.x >= xMin && point.x <= xMax && point.y >= yMin && point.y <= yMax;
		}

		/// <summary> Do two <see cref="Rect"/>s overlap, excluding cases where they just touch edges? </summary>
		public bool Overlaps(Rect other) {
			return other.xMax > xMin && other.xMin < xMax && other.yMax > yMin && other.yMin < yMax;
		}
		/// <summary> Do two <see cref="Rect"/>s overlap, including cases where they just touch edges? </summary>
		public bool Touches(Rect other) {
			return other.xMax >= xMin && other.xMin <= xMax && other.yMax >= yMin && other.yMin <= yMax;
		}
		/// <summary> Get a point within the <see cref="Rect"/> at <paramref name="coords"/>. In normalized coords, (0,0) means top-left of rect, (1,1) means bottom-right </summary>
		public Vector2 NormalizedToPoint(Vector2 coords) {
			return new Vector2(Lerp(x, xMax, coords.x), Lerp(y, yMax, coords.y));
		}
		/// <summary> Get the normalized coords within the <see cref="Rect"/> at the given <paramref name="point"/>. In normalized coords, (0,0) means top-left of rect, (1,1) means bottom-right </summary>
		public Vector2 PointToNormalized(Vector2 point) {
			return new Vector2(InverseLerp(x, xMax, point.x), InverseLerp(y, yMax, point.y));
		}

		/// <summary> Modifies this <see cref="Rect"/> so that it's <see cref="min"/> and <see cref="max"/> are <paramref name="min"/> and <paramref name="max"/>. </summary>
		public void SetMinMax(Vector2 min, Vector2 max) {
			Vector2 size = max - min;
			x = min.x; y = min.y;
			width = size.x; height = size.y;
		}
		/// <summary> Forces this <see cref="Rect"/> to fit within the given <paramref name="bounds"/>. </summary>
		/// <param name="bounds"></param>
		public void ClampToBounds(Rect bounds) {
			Vector2 min = Vector2.Max(this.min, bounds.min);
			Vector2 max = Vector2.Min(this.max, bounds.max);
			SetMinMax(min, max);
		}

		/// <summary> Create a new <see cref="Rect"/> from the given min/max values. </summary>
		/// <remarks> Has to be separated since it has the same signature as standard constructor. </remarks>
		public static Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax) {
			float w = xmax - xmin;
			float h = ymax - ymin;
			return new Rect(xmin, ymin, w, h);
		}

		/// <summary> Get a point within the given <see cref="Rect"/> at <paramref name="coords"/>. In normalized coords, (0,0) means top-left of rect, (1,1) means bottom-right </summary>
		public static Vector2 NormalizedToPoint(Rect rect, Vector2 coords) {
			return new Vector2(Lerp(rect.x, rect.xMax, coords.x), Lerp(rect.y, rect.yMax, coords.y));
		}
		/// <summary> Get the normalized coords within the given <see cref="Rect"/> at the given <paramref name="point"/>. In normalized coords, (0,0) means top-left of rect, (1,1) means bottom-right </summary>
		public static Vector2 PointToNormalized(Rect rect, Vector2 point) {
			return new Vector2(InverseLerp(rect.x, rect.xMax, point.x), InverseLerp(rect.y, rect.yMax, point.y));
		}
		
		/// <summary> Compare the location and size of two <see cref="Rect"/>s for equality </summary>
		public static bool operator ==(Rect a, Rect b) { return a.x == b.x && a.y == b.y && a.width == b.width && a.height == b.height; }
		/// <summary> Inverse compare the location and size of two <see cref="Rect"/>s for equality </summary>
		public static bool operator !=(Rect a, Rect b) { return !(a == b); }
	}
	#endregion
	#region RectInt
	/// <summary> Class similar to UnityEngine.RectInt. Stores four <see cref="int"/>s, like what would be Vector4Int, but interprets them as a Rectangle. (x,y) x (width, height) </summary>
	[System.Serializable]
	public struct RectInt : IEquatable<RectInt> {
		/// <summary> Position information </summary>
		public int x, y;
		/// <summary> Size information </summary>
		public int width, height;

		/// <summary> Construct a <see cref="RectInt"/> with the given position/size </summary>
		public RectInt(int x, int y, int width, int height) { this.x = x; this.y = y; this.width = width; this.height = height; }
		/// <summary> Construct a <see cref="RectInt"/> with the given position/size </summary>
		public RectInt(Vector2Int pos, Vector2Int size) { x = pos.x; y = pos.y; width = size.x; height = size.y; }
		/// <summary> Construct a <see cref="RectInt"/> as a copy of another </summary>
		public RectInt(RectInt source) { x = source.x; y = source.y; width = source.width; height = source.height; }

		/// <summary> get/set the top-left position of this <see cref="RectInt"/> as a <see cref="Vector2Int"/>. </summary>
		public Vector2Int position {
			get { return new Vector2Int(x, y); }
			set { x = value.x; y = value.y; }
		}
		/// <summary> get/set the center position of this <see cref="RectInt"/> as a <see cref="Vector2Int"/>. </summary>
		/// <remarks> set may be a bit imprecise due to float conversions. </remarks>
		public Vector2 center {
			get { return new Vector2(x + width / 2f, y + height / 2f); }
			set { x = (int)(value.x - width/2f); y = (int)(value.y - height/2f); }
		}
		/// <summary> get/set the minimum position of this <see cref="RectInt"/> as a <see cref="Vector2Int"/>. </summary>
		public Vector2Int min {
			get { return new Vector2Int(x, y); }
			set { x = value.x; y = value.y; }
		}
		/// <summary> get/set the maximum position of this <see cref="RectInt"/> as a <see cref="Vector2Int"/>. </summary>
		public Vector2Int max {
			get { return new Vector2Int(x + width, y + height); }
			set { Vector2Int size = value - min; width = size.x; height = size.y; }
		}
		/// <summary> get/set the size of this <see cref="RectInt"/> as a <see cref="Vector2Int"/>. </summary>
		public Vector2Int size {
			get { return new Vector2Int(width, height); }
			set { width = value.x; height = value.y; }
		}

		/// <summary> get the min x-coord of this <see cref="RectInt"/> </summary>
		public int xMin { get { return x; } set { int xm = xMax; x = value; width = xm - x; } }
		/// <summary> get the min y-coord of this <see cref="RectInt"/> </summary>
		public int yMin { get { return y; } set { int ym = yMax; y = value; height = ym - y; } }
		/// <summary> get the max x-coord of this <see cref="RectInt"/> </summary>
		public int xMax { get { return x + width; } set { width = value - x; } }
		/// <summary> get the max y-coord of this <see cref="RectInt"/> </summary>
		public int yMax { get { return y + height; } set { height = value - y; } }

		/// <summary> get the left edge of this <see cref="RectInt"/> </summary>
		public int left { get { return x; } }
		/// <summary> get the right edge of this <see cref="RectInt"/> </summary>
		public int right { get { return x + width; } }
		/// <summary> get the top edge of this <see cref="RectInt"/> </summary>
		public int top { get { return y; } }
		/// <summary> get the bottom edge of this <see cref="RectInt"/> </summary>
		public int bottom { get { return y + height; } }

		/// <summary> Modifies this <see cref="RectInt"/> so that it's <see cref="min"/> and <see cref="max"/> are <paramref name="min"/> and <paramref name="max"/>. </summary>
		public void SetMinMax(Vector2Int min, Vector2Int max) {
			Vector2Int size = max-min;
			x = min.x; y = min.y;
			width = size.x; height = size.y;
		}
		/// <summary> Forces this <see cref="RectInt"/> to fit within the given <paramref name="bounds"/>. </summary>
		/// <param name="bounds"></param>
		public void ClampToBounds(RectInt bounds) {
			Vector2Int min = Vector2Int.Max(this.min, bounds.min);
			Vector2Int max = Vector2Int.Min(this.max, bounds.max);
			SetMinMax(min, max);
		}

		/// <summary> Iterate all positions within this <see cref="RectInt"/> </summary>
		IEnumerator<Vector2Int> Points() {
			for (int yy = y; yy < height; yy++) {
				for (int xx = x; xx < width; xx++) {
					yield return new Vector2Int(xx,yy);
				}
			}
		}

		/// <inheritdoc />
		public override bool Equals(object other) { return other is RectInt && Equals((RectInt)other); }
		/// <summary> Test two <see cref="RectInt"/>s position and size for equality. </summary>
		public bool Equals(RectInt other) { return x == other.x && y == other.y && width == other.width && height == other.height; }
		/// <inheritdoc />
		public override string ToString() { return $"(x:{x}, y:{y}, width:{width}, height:{height})"; }
		/// <inheritdoc />
		public override int GetHashCode() { return x.GetHashCode() ^ (width.GetHashCode() << 2) ^ (y.GetHashCode() >> 2) ^ (height.GetHashCode() >> 1); }
	}
	#endregion
	#region Plane
	/// <summary> Similar to UnityEngine.Plane, represents a 3d Plane object by a <see cref="normal"/> and <see cref="distance"/> along the normal from the origin. </summary>
	[System.Serializable]
	public struct Plane {

		/// <summary> Internal field backing <see cref="normal"/> property. </summary>
		private Vector3 _normal;
		/// <summary> Distance from origin to <see cref="Plane"/> surface, along the given normal. </summary>
		public float distance;
		/// <summary> Signed normal direction of the <see cref="Plane"/>. </summary>
		public Vector3 normal { get { return _normal; } set { _normal = value.normalized; } }

		/// <summary> Construct a <see cref="Plane"/> with the given normal, and a point in space. </summary>
		public Plane(Vector3 normal, Vector3 point) {
			this._normal = normal.normalized;
			distance = -Vector3.Dot(normal, point);
		}
		/// <summary> Construct a <see cref="Plane"/> with the given normal, and a distance along the normal. </summary>
		public Plane(Vector3 normal, float distance) {
			this._normal = normal.normalized;
			this.distance = distance;
		}
		/// <summary> Construct a <see cref="Plane"/> that contains the given verticies. </summary>
		public Plane(Vector3 a, Vector3 b, Vector3 c) {
			_normal = Vector3.Cross(b - a, c - a).normalized;
			distance = -Vector3.Dot(_normal, a);
		}
		/// <summary> Create a <see cref="Plane"/> that is the 'flip' of this <see cref="Plane"/> (same position, opposite facing direction) </summary>
		public Plane flipped { get { return new Plane(-_normal, -distance); } }

		/// <inheritdoc />
		public override string ToString() { return $"(Normal: {normal}, Distance: {distance})"; }

		/// <summary> Modify this <see cref="Plane"/> so it intersects <paramref name="point"/> and faces along <paramref name="normal"/>. </summary>
		public void SetNormalAndPosition(Vector3 normal, Vector3 point) {
			this._normal = normal.normalized;
			distance = -Vector3.Dot(normal, point);
		}
		/// <summary> Modify this <see cref="Plane"/> so it intersects all 3 given points. </summary>
		public void Set3Points(Vector3 a, Vector3 b, Vector3 c) {
			_normal = Vector3.Cross(b - a, c - a).normalized;
			distance = -Vector3.Dot(_normal, a);
		}
		/// <summary> Modify this <see cref="Plane"/> so it faces the opposite way. </summary>
		public void Flip() { _normal = -_normal; distance = -distance; }
		/// <summary> Translate this <see cref="Plane"/> along the given <paramref name="translation"/>. </summary>
		public void Translate(Vector3 translation) { distance += Vector3.Dot(_normal, translation); }

		/// <summary> Derive a <see cref="Plane"/> from <paramref name="p"/> translated along <paramref name="translation"/>. </summary>
		public static Plane Translate(Plane p, Vector3 translation) { return new Plane(p._normal, p.distance + Vector3.Dot(p._normal, translation)); }

		/// <summary> Find the closest point on the <see cref="Plane"/> from a given <paramref name="point"/>. </summary>
		public Vector3 ClosestPointOnPlane(Vector3 point) {
			float d = Vector3.Dot(_normal, point) + distance;
			return point - _normal * d;
		}
		/// <summary> Find the distance to the given <paramref name="point"/>. </summary>
		public float GetDistanceToPoint(Vector3 point) { return Vector3.Dot(_normal, point) + distance; }
		/// <summary> Get if the given point is "above" (positive side, true) the <see cref="Plane"/> or "below" (negative side, false) </summary>
		public bool GetSide(Vector3 point) { return Vector3.Dot(_normal, point) + distance > 0f; }
		/// <summary> Get if two points are on the same side of the given <see cref="Plane"/> </summary>
		public bool SameSide(Vector3 a, Vector3 b) {
			float da = GetDistanceToPoint(a);
			float db = GetDistanceToPoint(b);
			return (da > 0f && db > 0f) || (da <= 0f && db <= 0f);
		}

		/// <summary> Cast a <paramref name="ray"/> against this plane, and get the <paramref name="enter"/> if it intersects. </summary>
		/// <param name="ray"> <see cref="Ray"/> to cast against plane </param>
		/// <param name="enter"> Output distance along <paramref name="ray"/> where intersection occured, if it occurred. </param>
		/// <returns> True, if <paramref name="ray"/> intersects this plane, false otherwise. </returns>
		public bool Raycast(Ray ray, out float enter) {
			float angle = Vector3.Dot(ray.direction, _normal);
			if (Approximately(angle, 0f)) {
				enter = 0f;
				return false;
			}
			float distance = -Vector3.Dot(ray.origin, _normal) - this.distance;
			enter = distance / angle;
			return (enter > 0f);
		}
	}
	#endregion
	#region Ray
	/// <summary> Similar to UnityEngine.Ray Represents a Ray in 3d Space, <see cref="origin"/>ating at some point, and firing in some <see cref="dir"/>ection. </summary>
	[System.Serializable]
	public struct Ray {
		/// <summary> Origin point of <see cref="Ray"/> </summary>
		public Vector3 origin;
		/// <summary> Normalized direction of <see cref="Ray"/> </summary>
		public Vector3 dir;
		/// <summary> Constructs a <see cref="Ray"/> with the given <paramref name="origin"/> and <paramref name="dir"/>ection. </summary>
		public Ray(Vector3 origin, Vector3 dir) { this.origin = origin; this.dir = dir.normalized; }
		/// <summary> Gets/sets the normalized direction of this <see cref="Ray"/> </summary>
		public Vector3 direction { get { return dir; } set { dir = value.normalized; } }

		/// <inheritdoc />
		public override string ToString() { return $"(Origin: {origin} Direction: {dir})"; }
		/// <summary> Calculate the point <paramref name="distance"/> along the <see cref="dir"/>ection of this <see cref="Ray"/> from its <see cref="origin"/>. </summary>
		public Vector3 GetPoint(float distance) { return origin + dir * distance; }
	}
	#endregion
	#region Ray2D
	/// <summary> Similar to UnityEngine.Ray2D Represents a Ray in 2d Space, <see cref="origin"/>ating at some point, and firing in some <see cref="dir"/>ection. </summary>
	[System.Serializable]
	public struct Ray2D {
		/// <summary> Origin point of <see cref="Ray2D"/> </summary>
		public Vector2 origin;
		/// <summary> Normalized direction of <see cref="Ray2D"/> </summary>
		public Vector2 dir;
		/// <summary> Constructs a <see cref="Ray2D"/> with the given <paramref name="origin"/> and <paramref name="dir"/>ection. </summary>
		public Ray2D(Vector2 origin, Vector2 dir) { this.origin = origin; this.dir = dir.normalized; }
		/// <summary> Gets/sets the normalized direction of this <see cref="Ray2D"/> </summary>
		public Vector2 direction { get { return dir; } set { dir = value.normalized; } }

		/// <inheritdoc />
		public override string ToString() { return $"(Origin: {origin} Direction: {dir})"; }
		/// <summary> Calculate the point <paramref name="distance"/> along the <see cref="dir"/>ection of this <see cref="Ray2D"/> from its <see cref="origin"/>. </summary>
		public Vector2 GetPoint(float distance) { return origin + dir * distance; }
	}
	#endregion

	#region Bounds aka AABB
	/// <summary> Similar to UnityEngine.Bounds, represents an Axis-Aligned-Bounding-Box. </summary>
	[System.Serializable]
	public struct Bounds : IEquatable<Bounds> {
		/// <summary> Center of bounding box </summary>
		public Vector3 center;
		/// <summary> Half-size of bounding box. </summary>
		public Vector3 extents;

		/// <summary> Create a new <see cref="Bounds"/>, centered at the given <paramref name="center"/>, and with the given total <paramref name="size"/>. </summary>
		public Bounds(Vector3 center, Vector3 size) { this.center = center; extents = (size / 2f).Abs(); }
		/// <summary> Get the full size of the <see cref="Bounds"/> </summary>
		public Vector3 size { get { return extents * 2f; } set { extents = (value / 2f).Abs(); } }
		/// <summary> Get the minimum point in the <see cref="Bounds"/> </summary>
		public Vector3 min { get { return center - extents; } set { SetMinMax(value, max); } }
		/// <summary> Get the maximum point in the <see cref="Bounds"/> </summary>
		public Vector3 max { get { return center + extents; } set { SetMinMax(min, value); } }

		/// <inheritdoc />
		public override bool Equals(object other) { return other is Bounds && Equals((Bounds)other); }
		/// <summary> Compare two <see cref="Bounds"/>'s <see cref="center"/> and <see cref="size"/> for equality </summary>
		public bool Equals(Bounds other) { return center.Equals(other.center) && extents.Equals(other.extents); }
		/// <inheritdoc />
		public override int GetHashCode() { return center.GetHashCode() ^ extents.GetHashCode() << 2; }
		/// <inheritdoc />
		public override string ToString() { return $"(Center: {center}, Extents: {extents})"; }

		/// <summary> Directly modify both the min and max points of this <see cref="Bounds"/>. </summary>
		public void SetMinMax(Vector3 min, Vector3 max) { extents = ((max - min) * 0.5f).Abs(); center = min + extents; }
		/// <summary> Grow the <see cref="Bounds"/> so it encapsulates the given <paramref name="point"/>. </summary>
		public void Encapsulate(Vector3 point) { SetMinMax(Vector3.Min(min, point), Vector3.Max(max, point)); }
		/// <summary> Grow the <see cref="Bounds"/> so it also encapsulates the entire given <paramref name="bounds"/>. </summary>
		public void Encapsulate(Bounds bounds) { Encapsulate(bounds.center - bounds.extents); Encapsulate(bounds.center + bounds.extents); }
		/// <summary> Expand the <see cref="Bounds"/> in all directions by <paramref name="amount"/>. </summary>
		public void Expand(float amount) { var a = Abs(amount * .5f); extents += new Vector3(a, a, a); }
		/// <summary> Expand the <see cref="Bounds"/> in the directions given by <paramref name="amount"/>. </summary>
		public void Expand(Vector3 amount) { extents += (amount * .5f).Abs(); }


		/// <summary> Get the Minkowski Difference between this and another <see cref="Bounds"/> </summary>
		/// <remarks>https://blog.hamaluik.ca/posts/simple-aabb-collision-using-minkowski-difference/</remarks>
		public Bounds Minkowski(Bounds other) { 
			Bounds result = default;
			Vector3 topLeft = min - other.max;
			Vector3 ext = (size + other.size) / 2.0f;
			
			result.center = topLeft + ext;
			result.extents = ext;
			return result;
		}
		
		/// <summary> Does this <see cref="Bounds"/> intersect the other <paramref name="bounds"/>? </summary>
		public bool Intersects(Bounds bounds) {
			Vector3 amin = min; Vector3 amax = max;
			Vector3 bmin = bounds.min; Vector3 bmax = bounds.max;
			return amin.x <= bmax.x && amax.x >= bmin.x
				&& amin.y <= bmax.y && amax.y >= bmin.y
				&& amin.z <= bmax.z && amax.z >= bmin.z;
		}
		/// <summary> Does this <see cref="Bounds"/> contain the given <paramref name="point"/>? </summary>
		public bool Contains(Vector3 point) {
			Vector3 min = this.min; Vector3 max = this.max;
			return point.x <= max.x && point.x >= min.x
				&& point.y <= max.y && point.y >= min.y
				&& point.z <= max.z && point.z >= min.z;
		}
		/// <summary> Does the given <paramref name="r"/>ay intersect this <see cref="Bounds"/>? </summary>
		public bool Intersects(Ray r) {
			Vector3 min = this.min; Vector3 max = this.max;
			Vector3 inv = 1f / r.dir;
			float tmin = -Infinity;
			float tmax = Infinity;

			float x1 = (min.x - r.origin.x) * inv.x;
			float x2 = (max.x - r.origin.x) * inv.x;
			tmin = Max(tmin, Min(x1, x2));
			tmax = Min(tmax, Max(x1, x2));
			float y1 = (min.y - r.origin.y) * inv.y;
			float y2 = (max.y - r.origin.y) * inv.y;
			tmin = Max(tmin, Min(y1, y2));
			tmax = Min(tmax, Max(y1, y2));
			float z1 = (min.z - r.origin.z) * inv.z;
			float z2 = (max.z - r.origin.z) * inv.z;
			tmin = Max(tmin, Min(z1, z2));
			tmax = Min(tmax, Max(z1, z2));

			return tmax >= tmin;
		}
		
		/// <summary> Gets the point on this <see cref="Bounds"/> closest to the given <paramref name="point"/>. </summary>
		public Vector3 ClosestPoint(Vector3 point) {
			Vector3 relativePoint = point - center;
			Vector3 mirroredPoint = relativePoint.Abs();
			Vector3 distanceToSurface = Vector3.Max(Vector3.zero, mirroredPoint - extents);

			if (relativePoint.x < 0) { distanceToSurface.x *= -1; }
			if (relativePoint.y < 0) { distanceToSurface.y *= -1; }
			if (relativePoint.z < 0) { distanceToSurface.z *= -1; }

			return point - distanceToSurface;
		}

		/// <summary> Signed distance from the surface of this <see cref="Bounds"/> to the given <paramref name="point"/> </summary>
		public float Distance(Vector3 point) {
			Vector3 relativePoint = point - center;
			Vector3 q = relativePoint.Abs() - extents;

			return Vector3.Max(q, Vector3.zero).magnitude + Min(Max(q.x, Max(q.y, q.z)), 0.0f);
		}

	}
	/// <summary> Similar to UnityEngine.Bounds, represents an Axis-Aligned-Bounding-Box. </summary>
	[System.Serializable]
	public struct BoundsInt : IEquatable<BoundsInt> {
		/// <summary> Minimum position of this <see cref="BoundsInt"/> </summary>
		public Vector3Int position;
		/// <summary> Size of bounding box. </summary>
		public Vector3Int size;

		/// <summary> Directly get/set the x-position of this <see cref="BoundsInt"/> </summary>
		public int x { get { return position.x; } set { position.x = value; } }
		/// <summary> Directly get/set the y-position of this <see cref="BoundsInt"/> </summary>
		public int y { get { return position.x; } set { position.y = value; } }
		/// <summary> Directly get/set the z-position of this <see cref="BoundsInt"/> </summary>
		public int z { get { return position.z; } set { position.z = value; } }

		/// <summary> Create a new <see cref="BoundsInt"/>, placed at the given <paramref name="position"/>, and with the given total <paramref name="size"/>. </summary>
		public BoundsInt(Vector3Int position, Vector3Int size) { this.position = position; this.size = size; }
		/// <summary> Create a new <see cref="BoundsInt"/>, placed at the given position and with the given total size. </summary>
		public BoundsInt(int xMin, int yMin, int zMin, int sizeX, int sizeY, int sizeZ) {
			position = new Vector3Int(xMin, yMin, zMin);
			size = new Vector3Int(sizeX, sizeY, sizeZ);
		}

		/// <summary> Calculate the center position of this <see cref="BoundsInt"/> </summary>
		public Vector3 center { get { return position + ((Vector3)size) / 2f; } }

		/// <summary> Minimum x-coordinate in the <see cref="BoundsInt"/>. </summary>
		public int xMin { get { return Min(x, x+size.x); } set { int xmax = xMax; x = value; size.x = xmax - x; } }
		/// <summary> Minimum y-coordinate in the <see cref="BoundsInt"/>. </summary>
		public int yMin { get { return Min(y, y+size.y); } set { int ymax = yMax; y = value; size.y = ymax - y; } }
		/// <summary> Minimum z-coordinate in the <see cref="BoundsInt"/>. </summary>
		public int zMin { get { return Min(z, z+size.z); } set { int zmax = zMax; z = value; size.z = zmax - z; } }
		/// <summary> Maximum x-coordinate in the <see cref="BoundsInt"/>. </summary>
		public int xMax { get { return Max(x, x+size.x); } set { size.x = value - x; } }
		/// <summary> Maximum y-coordinate in the <see cref="BoundsInt"/>. </summary>
		public int yMax { get { return Max(y, y+size.y); } set { size.y = value - y; } }
		/// <summary> Maximum z-coordinate in the <see cref="BoundsInt"/>. </summary>
		public int zMax { get { return Max(z, z+size.z); } set { size.z = value - z; } }

		/// <summary> Get the minimum point in the <see cref="BoundsInt"/> </summary>
		public Vector3Int min { get { return new Vector3Int(xMin, yMin, zMin); } set { xMin = value.x; yMin = value.y; zMin = value.z; } }
		/// <summary> Get the maximum point in the <see cref="BoundsInt"/> </summary>
		public Vector3Int max { get { return new Vector3Int(xMax, yMax, zMax); } set { xMax = value.x; yMax = value.y; zMax = value.z; } }
		
		/// <inheritdoc />
		public override bool Equals(object other) { return other is BoundsInt && Equals((BoundsInt)other); }
		/// <summary> Compare two <see cref="BoundsInt"/>'s <see cref="position"/> and <see cref="size"/> for equality </summary>
		public bool Equals(BoundsInt other) { return position.Equals(other.position) && size.Equals(other.size); }
		/// <inheritdoc />
		public override int GetHashCode() { return position.GetHashCode() ^ size.GetHashCode() << 2; }
		/// <inheritdoc />
		public override string ToString() { return $"(Center: {position}, Extents: {size})"; }


		/// <summary> Directly modify both the min and max points of this <see cref="BoundsInt"/>. </summary>
		public void SetMinMax(Vector3Int min, Vector3Int max) { size = ((max - min)/2).Abs(); position = min + size; }
		/// <summary> Grow the <see cref="BoundsInt"/> so it encapsulates the given <paramref name="point"/>. </summary>
		public void Encapsulate(Vector3Int point) { SetMinMax(Vector3Int.Min(min, point), Vector3Int.Max(max, point)); }
		/// <summary> Grow the <see cref="BoundsInt"/> so it also encapsulates the entire given <paramref name="bounds"/>. </summary>
		public void Encapsulate(BoundsInt bounds) { Encapsulate(bounds.position - bounds.size); Encapsulate(bounds.position + bounds.size); }
		/// <summary> Expand the <see cref="BoundsInt"/> in all directions by <paramref name="amount"/>. </summary>
		public void Expand(int amount) { size += new Vector3Int(amount, amount, amount); }
		/// <summary> Expand the <see cref="BoundsInt"/> in the directions given by <paramref name="amount"/>. </summary>
		public void Expand(Vector3Int amount) { size += amount.Abs(); }

		/// <summary> Does this <see cref="BoundsInt"/> intersect the other <paramref name="bounds"/>? </summary>
		public bool Intersects(BoundsInt bounds) {
			Vector3Int amin = min; Vector3Int amax = max;
			Vector3Int bmin = bounds.min; Vector3Int bmax = bounds.max;
			return amin.x <= bmax.x && amax.x >= bmin.x
				&& amin.y <= bmax.y && amax.y >= bmin.y
				&& amin.z <= bmax.z && amax.z >= bmin.z;
		}
		/// <summary> Does this <see cref="BoundsInt"/> contain the given <paramref name="point"/>? </summary>
		public bool Contains(Vector3Int point) {
			Vector3Int min = this.min; Vector3Int max = this.max;
			return point.x <= max.x && point.x >= min.x
				&& point.y <= max.y && point.y >= min.y
				&& point.z <= max.z && point.z >= min.z;
		}
		/// <summary> Does the given <paramref name="r"/>ay intersect this <see cref="BoundsInt"/>? </summary>
		public bool Intersects(Ray r) {
			Vector3 min = this.min; Vector3 max = this.max;
			Vector3 inv = 1f / r.dir;
			float tmin = -Infinity;
			float tmax = Infinity;

			float x1 = (min.x - r.origin.x) * inv.x;
			float x2 = (max.x - r.origin.x) * inv.x;
			tmin = Max(tmin, Min(x1, x2));
			tmax = Min(tmax, Max(x1, x2));
			float y1 = (min.y - r.origin.y) * inv.y;
			float y2 = (max.y - r.origin.y) * inv.y;
			tmin = Max(tmin, Min(y1, y2));
			tmax = Min(tmax, Max(y1, y2));
			float z1 = (min.z - r.origin.z) * inv.z;
			float z2 = (max.z - r.origin.z) * inv.z;
			tmin = Max(tmin, Min(z1, z2));
			tmax = Min(tmax, Max(z1, z2));

			return tmax >= tmin;
		}

		/// <summary> Gets the point on this <see cref="BoundsInt"/> closest to the given <paramref name="point"/>. </summary>
		public Vector3 ClosestPoint(Vector3 point) {
			Vector3 relativePoint = point - center;
			Vector3 mirroredPoint = relativePoint.Abs();
			Vector3 distanceToSurface = Vector3.Max(Vector3.zero, mirroredPoint - size);

			if (relativePoint.x < 0) { distanceToSurface.x *= -1; }
			if (relativePoint.y < 0) { distanceToSurface.y *= -1; }
			if (relativePoint.z < 0) { distanceToSurface.z *= -1; }

			return point - distanceToSurface;
		}

		/// <summary> Signed distance from the surface of this <see cref="BoundsInt"/> to the given <paramref name="point"/> </summary>
		public float Distance(Vector3 point) {
			Vector3 relativePoint = point - position;
			Vector3 q = relativePoint.Abs() - size;

			return Vector3.Max(q, Vector3.zero).magnitude + Min(Max(q.x, Max(q.y, q.z)), 0);
		}

	}

	/// <summary> Similar to UnityEngine.Matrix4x4. 4-by-4 Matrix for 3d transformations. </summary> 
	public struct Matrix4x4 {
		/// <summary> Get zero (empty) <see cref="Matrix4x4"/></summary>
		public static Matrix4x4 zero { get; } = new Matrix4x4();
		/// <summary> Creates an identity matrix. </summary>
		public static Matrix4x4 identity { get; } = new Matrix4x4(
			1, 0, 0, 0,
			0, 1, 0, 0,
			0, 0, 1, 0,
			0, 0, 0, 1);

		/// <summary> Calculate the determinant of this matrix. </summary>
		public float determinant {
			get {
				float kp = k * p; float lo = l * o; float jp = j * p; 
				float ln = l * n; float jo = j * o; float kn = k * n;
				float ip = i * p; float lm = l * m; float km = k * m; 
				float @in = i * n;float jm = j * m;
				float io = i * o;
				
				return a * (f*kp - f*lo - g*jp + g*ln + h*jo + h*kn)
					+ b * (e*kp - e*lo - g*ip + g*lm + h*jo - h*kn)
					+ c * (e*jp - e*ln - f*ip + f*lm+ h*@in - h*jm)
					+ d * (e*jo - e*kn - f*io + f*km + g*@in - g*jm);
			}
		}
		/// <summary> Matrix component. </summary>
		public float	m00, m10, m20, m30, 
						m01, m11, m21, m31, 
						m02, m12, m22, m32, 
						m03, m13, m23, m33;

		/// <summary> Figure out if a matrix is invertable, and capture its <see cref="determinant"/>. </summary>
		/// <param name="detOut"> Output parameter for the captured <see cref="determinant"/></param>
		public bool Invertable(out float detOut) {
			float det = detOut = determinant;
			return (det != 0);
		}

		/// <summary> Calculates the inverse <see cref="Matrix4x4"/> of this one, if possible. If not, returns <see cref="zero"/>. </summary>
		public Matrix4x4 inverse {
			get { 
				Matrix4x4 inv = default;
				inv.m00 = m11 * m22 * m33 - m11 * m32 * m23 - m12 * m21 * m33 + m12 * m31 * m23 + m13 * m21 * m32 - m13 * m31 * m22;
				inv.m10 = -m10 * m22 * m33 + m10 * m32 * m23 + m12 * m20 * m33 - m12 * m30 * m23 - m13 * m20 * m32 + m13 * m30 * m22;
				inv.m20 = m10 * m21 * m33 - m10 * m31 * m23 - m11 * m20 * m33 + m11 * m30 * m23 + m13 * m20 * m31 - m13 * m30 * m21;
				inv.m30 = -m10 * m21 * m32 + m10 * m31 * m22 + m11 * m20 * m32 - m11 * m30 * m22 - m12 * m20 * m31 + m12 * m30 * m21;
				inv.m01 = -m01 * m22 * m33 + m01 * m32 * m23 + m02 * m21 * m33 - m02 * m31 * m23 - m03 * m21 * m32 + m03 * m31 * m22;
				inv.m11 = m00 * m22 * m33 - m00 * m32 * m23 - m02 * m20 * m33 + m02 * m30 * m23 + m03 * m20 * m32 - m03 * m30 * m22;
				inv.m21 = -m00 * m21 * m33 + m00 * m31 * m23 + m01 * m20 * m33 - m01 * m30 * m23 - m03 * m20 * m31 + m03 * m30 * m21;
				inv.m31 = m00 * m21 * m32 - m00 * m31 * m22 - m01 * m20 * m32 + m01 * m30 * m22 + m02 * m20 * m31 - m02 * m30 * m21;
				inv.m02 = m01 * m12 * m33 - m01 * m32 * m13 - m02 * m11 * m33 + m02 * m31 * m13 + m03 * m11 * m32 - m03 * m31 * m12;
				inv.m12 = -m00 * m12 * m33 + m00 * m32 * m13 + m02 * m10 * m33 - m02 * m30 * m13 - m03 * m10 * m32 + m03 * m30 * m12;
				inv.m22 = m00 * m11 * m33 - m00 * m31 * m13 - m01 * m10 * m33 + m01 * m30 * m13 + m03 * m10 * m31 - m03 * m30 * m11;
				inv.m32 = -m00 * m11 * m32 + m00 * m31 * m12 + m01 * m10 * m32 - m01 * m30 * m12 - m02 * m10 * m31 + m02 * m30 * m11;
				inv.m03 = -m01 * m12 * m23 + m01 * m22 * m13 + m02 * m11 * m23 - m02 * m21 * m13 - m03 * m11 * m22 + m03 * m21 * m12;
				inv.m13 = m00 * m12 * m23 - m00 * m22 * m13 - m02 * m10 * m23 + m02 * m20 * m13 + m03 * m10 * m22 - m03 * m20 * m12;
				inv.m23 = -m00 * m11 * m23 + m00 * m21 * m13 + m01 * m10 * m23 - m01 * m20 * m13 - m03 * m10 * m21 + m03 * m20 * m11;
				inv.m33 = m00 * m11 * m22 - m00 * m21 * m12 - m01 * m10 * m22 + m01 * m20 * m12 + m02 * m10 * m21 - m02 * m20 * m11;

				float det = m00 * inv.m00 + m10 * inv.m01 + m20 * inv.m02 + m30 * inv.m03;
				if (det == 0) { return zero; }

				det = 1.0f / det;
				for (int i = 0; i < 16; i++) { inv[i] *= det; }

				return inv;
			}
		}

		/// <summary> Get the transpose of this matrix </summary>
		public Matrix4x4 transpose {
			get {
				return new Matrix4x4(m00, m01, m02, m03,
									m10, m11, m12, m13,
									m20, m21, m22, m23,
									m30, m31, m32, m33);
			}
		}
		
		/// <summary> Alternate naming scheme accessor. (<see cref="m00"/>) </summary>
		public float a { get { return m00; } set { m00 = value; } }
		/// <summary> Alternate naming scheme accessor. (<see cref="m10"/>) </summary>
		public float b { get { return m10; } set { m10 = value; } }
		/// <summary> Alternate naming scheme accessor. (<see cref="m20"/>) </summary>
		public float c { get { return m20; } set { m20 = value; } }
		/// <summary> Alternate naming scheme accessor. (<see cref="m30"/>) </summary>
		public float d { get { return m30; } set { m30 = value; } }
		/// <summary> Alternate naming scheme accessor. (<see cref="m01"/>) </summary>
		public float e { get { return m01; } set { m01 = value; } }
		/// <summary> Alternate naming scheme accessor. (<see cref="m11"/>) </summary>
		public float f { get { return m11; } set { m11 = value; } }
		/// <summary> Alternate naming scheme accessor. (<see cref="m21"/>) </summary>
		public float g { get { return m21; } set { m21 = value; } }
		/// <summary> Alternate naming scheme accessor. (<see cref="m31"/>) </summary>
		public float h { get { return m31; } set { m31 = value; } }
		/// <summary> Alternate naming scheme accessor. (<see cref="m02"/>) </summary>
		public float i { get { return m02; } set { m02 = value; } }
		/// <summary> Alternate naming scheme accessor. (<see cref="m12"/>) </summary>
		public float j { get { return m12; } set { m12 = value; } }
		/// <summary> Alternate naming scheme accessor. (<see cref="m22"/>) </summary>
		public float k { get { return m22; } set { m22 = value; } }
		/// <summary> Alternate naming scheme accessor. (<see cref="m32"/>) </summary>
		public float l { get { return m32; } set { m32 = value; } }
		/// <summary> Alternate naming scheme accessor. (<see cref="m03"/>) </summary>
		public float m { get { return m03; } set { m03 = value; } }
		/// <summary> Alternate naming scheme accessor. (<see cref="m13"/>) </summary>
		public float n { get { return m13; } set { m13 = value; } }
		/// <summary> Alternate naming scheme accessor. (<see cref="m23"/>) </summary>
		public float o { get { return m23; } set { m23 = value; } }
		/// <summary> Alternate naming scheme accessor. (<see cref="m33"/>) </summary>
		public float p { get { return m33; } set { m33 = value; } }
		
		/// <summary> Construct a matrix from the given 16 components. </summary>
		public Matrix4x4(	float a00, float a10, float a20, float a30, 
							float a01, float a11, float a21, float a31,
							float a02, float a12, float a22, float a32,
							float a03, float a13, float a23, float a33) {
			m00 = a00; m10 = a10; m20 = a20; m30 = a30;
			m01 = a01; m11 = a11; m21 = a21; m31 = a31;
			m02 = a02; m12 = a12; m22 = a22; m32 = a32;
			m03 = a03; m13 = a13; m23 = a23; m33 = a33;
		}

		/// <summary> Construct a <see cref="Matrix4x4"/> from 4 column <see cref="Vector4"/>s </summary>
		public Matrix4x4(Vector4 col0, Vector4 col1, Vector4 col2, Vector4 col3) {
			m00 = col0.x; m01 = col1.x; m02 = col2.x; m03 = col3.x;
			m10 = col0.y; m11 = col1.y; m12 = col2.y; m13 = col3.y;
			m20 = col0.z; m21 = col1.z; m22 = col2.z; m23 = col3.z;
			m30 = col0.w; m31 = col1.w; m32 = col2.w; m33 = col3.w;
		}

		/// <summary> Index this <see cref="Matrix4x4"/> with a two int indexes  in range [0, 3], in row-major order. </summary>
		public float this[int row, int col] {
			get { return this[row + col * 4]; }
			set { this[row + col * 4] = value; }
		}
		/// <summary> Index this <see cref="Matrix4x4"/> with a single int index in range [0, 15]. </summary>
		public float this[int index] {
			get {
				switch (index) {
					case  0: return m00; case  1: return m10; case  2: return m20; case  3: return m30;
					case  4: return m01; case  5: return m11; case  6: return m21; case  7: return m31;
					case  8: return m02; case  9: return m12; case 10: return m22; case 11: return m32;
					case 12: return m03; case 13: return m13; case 14: return m23; case 15: return m33;
					default: throw new IndexOutOfRangeException($"Invalid matrix index {index}!");
				}
			}
			set {
				switch (index) {
					case  0: m00 = value; break; case  1: m10 = value; break; case  2: m20 = value; break; case  3: m30 = value; break;
					case  4: m01 = value; break; case  5: m11 = value; break; case  6: m21 = value; break; case  7: m31 = value; break;
					case  8: m02 = value; break; case  9: m12 = value; break; case 10: m22 = value; break; case 11: m32 = value; break;
					case 12: m03 = value; break; case 13: m13 = value; break; case 14: m23 = value; break; case 15: m33 = value; break;
					default: throw new IndexOutOfRangeException($"Invalid matrix index {index}!");
				}
			}
		}
		/// <summary> Multiplies this <see cref="Matrix4x4"/> by a given <see cref="Vector3"/> with an implicit 1 in the w-component. </summary>
		public Vector3 MultiplyPoint(Vector3 point) {
			Vector3 result = default;
			result.x = m00 * point.x + m01 * point.y + m02 * point.z + m03;
			result.y = m10 * point.x + m11 * point.y + m12 * point.z + m13;
			result.z = m20 * point.x + m21 * point.y + m22 * point.z + m23;
			float norm = m30 * point.x + m31 * point.y + m32 * point.z + m33;
			norm = 1f / norm;
			return result * norm;
		}

		/// <summary> Multiplies this <see cref="Matrix4x4"/> by a given <see cref="Vector3"/> with an implicit 1 in the w-component, but discards the re-normalization process. </summary>
		public Vector3 MultiplyPointDirect(Vector3 point) {
			Vector3 result = default;
			result.x = m00 * point.x + m01 * point.y + m02 * point.z + m03;
			result.y = m10 * point.x + m11 * point.y + m12 * point.z + m13;
			result.z = m20 * point.x + m21 * point.y + m22 * point.z + m23;
			return result;
		}
		/// <summary> Multiplies this <see cref="Matrix4x4"/> by a given <see cref="Vector3"/>, ignoring the 4th dimension. </summary>
		public Vector3 MultiplyVector(Vector3 point) {
			Vector3 result = default;
			result.x = m00 * point.x + m01 * point.y + m02 * point.z;
			result.y = m10 * point.x + m11 * point.y + m12 * point.z;
			result.z = m20 * point.x + m21 * point.y + m22 * point.z;
			return result;
		}

		/// <summary> Create a <see cref="Matrix4x4"/> that scales by the given scale <see cref="Vector3"/>. </summary>
		public static Matrix4x4 Scale(Vector3 v) {
			Matrix4x4 result = default;
			result.m00 = v.x;
				result.m11 = v.y;
					result.m22 = v.z;
						result.m33 = 1f;

			return result;
		}

		/// <summary> Create a <see cref="Matrix4x4"/> that translates by the given <see cref="Vector3"/>. </summary>
		public static Matrix4x4 Translate(Vector3 v) {
			Matrix4x4 result = default;
			result.m00 = 1;				result.m03 = v.x;
				result.m11 = 1;			result.m13 = v.y;
					result.m22 = 1;		result.m23 = v.z;
										result.m33 = 1;
			return result;
		}

		/// <summary> Create a <see cref="Matrix4x4"/> that rotates <paramref name="angle"/> degrees about the given <paramref name="axis"/>. </summary>
		public static Matrix4x4 Rotate(float angle, Vector3 axis) { return Rotate(angle, axis.x, axis.y, axis.z); }
		/// <summary> Create a <see cref="Matrix4x4"/> that rotates <paramref name="angle"/> degrees about the axis formed by given <paramref name="x"/>, <paramref name="y"/>, <paramref name="z"/>. </summary>
		public static Matrix4x4 Rotate(float angle, float x, float y, float z) {
			float c = Cos(angle * Deg2Rad);
			float s = Sin(angle * Deg2Rad);

			float d = 1.0f - c;
			Matrix4x4 result = new Matrix4x4(x*x*d+c, x*y*d-s*z, x*z*d+s*y, 0,
											 x*y*d+s*z, y*y*d+c, y*z*d-s*x, 0,
											 x*z*d-s*y, y*z*d+s*x, z*z*d+c, 0,
											 0, 0, 0, 1 );
			return result;
		}
		/// <summary> Creates a Perspective Frustrum <see cref="Matrix4x4"/>, looking through a window defined by 
		/// <paramref name="left"/>, <paramref name="right"/>, <paramref name="top"/>, <paramref name="bottom"/>, which is
		/// <paramref name="near"/> units away, up to <paramref name="far"/> units away </summary>
		public static Matrix4x4 Frustrum(float left, float right, float bottom, float top, float near, float far) {
			float l = left; float r = right; float b = bottom; float t = top; float n = near; float f = far;
			return new Matrix4x4(2*n/(r-l), 0, (r+l)/(r-l), 0,
								 0, 2*n/(t-b), (t+b)/(t-b), 0,
								 0, 0, - (f+n)/(f-n), -(2*f*n)/(f-n),
								 0, 0, -1, 0 );
		}


		/// <summary> Create a matrix looking from <paramref name="eye"/> at <paramref name="target"/>, with the given <paramref name="up"/>wards direction. </summary>
		public static Matrix4x4 LookAt(Vector3 eye, Vector3 target, Vector3 up) {
			Vector3 n = (target - eye); n.Normalize();
			Vector3 r = Vector3.Cross(n, up); r.Normalize();
			Vector3 w = Vector3.Cross(r, n); w.Normalize();

			Matrix4x4 translate = new Matrix4x4(1,0,0,-eye.x,
										0,1,0,-eye.y,
										0,0,1,-eye.z,
										0,0,0,1);

			Matrix4x4 rotate = new Matrix4x4(	r.x, r.y, r.z, 0,
												w.x, w.y, w.z, 0,
												-n.x, -n.y, -n.z, 0,
												0, 0, 0, 1);
			return rotate * translate;
		}
		
		/// <inheritdoc />
		public override string ToString() {
			return $"{m00}\t{m01}\t{m02}\t{m03}\n{m10}\t{m11}\t{m12}\t{m13}\n{m20}\t{m21}\t{m22}\t{m23}\n{m30}\t{m31}\t{m32}\t{m33}";
		}


		/// <summary> Multiply two <see cref="Matrix4x4"/>s, order matters. </summary>
		public static Matrix4x4 operator *(Matrix4x4 lhs, Matrix4x4 rhs) {
			Matrix4x4 result = default;
			result.m00 = lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01 + lhs.m20 * rhs.m02 + lhs.m30 * rhs.m03;
			result.m10 = lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11 + lhs.m20 * rhs.m12 + lhs.m30 * rhs.m13;
			result.m20 = lhs.m00 * rhs.m20 + lhs.m10 * rhs.m21 + lhs.m20 * rhs.m22 + lhs.m30 * rhs.m23;
			result.m30 = lhs.m00 * rhs.m30 + lhs.m10 * rhs.m31 + lhs.m20 * rhs.m32 + lhs.m30 * rhs.m33;

			result.m01 = lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01 + lhs.m21 * rhs.m02 + lhs.m31 * rhs.m03;
			result.m11 = lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11 + lhs.m21 * rhs.m12 + lhs.m31 * rhs.m13;
			result.m21 = lhs.m01 * rhs.m20 + lhs.m11 * rhs.m21 + lhs.m21 * rhs.m22 + lhs.m31 * rhs.m23;
			result.m31 = lhs.m01 * rhs.m30 + lhs.m11 * rhs.m31 + lhs.m21 * rhs.m32 + lhs.m31 * rhs.m33;

			result.m02 = lhs.m02 * rhs.m00 + lhs.m12 * rhs.m01 + lhs.m22 * rhs.m02 + lhs.m32 * rhs.m03;
			result.m12 = lhs.m02 * rhs.m10 + lhs.m12 * rhs.m11 + lhs.m22 * rhs.m12 + lhs.m32 * rhs.m13;
			result.m22 = lhs.m02 * rhs.m20 + lhs.m12 * rhs.m21 + lhs.m22 * rhs.m22 + lhs.m32 * rhs.m23;
			result.m32 = lhs.m02 * rhs.m30 + lhs.m12 * rhs.m31 + lhs.m22 * rhs.m32 + lhs.m32 * rhs.m33;

			result.m03 = lhs.m03 * rhs.m00 + lhs.m13 * rhs.m01 + lhs.m23 * rhs.m02 + lhs.m33 * rhs.m03;
			result.m13 = lhs.m03 * rhs.m10 + lhs.m13 * rhs.m11 + lhs.m23 * rhs.m12 + lhs.m33 * rhs.m13;
			result.m23 = lhs.m03 * rhs.m20 + lhs.m13 * rhs.m21 + lhs.m23 * rhs.m22 + lhs.m33 * rhs.m23;
			result.m33 = lhs.m03 * rhs.m30 + lhs.m13 * rhs.m31 + lhs.m23 * rhs.m32 + lhs.m33 * rhs.m33;
			return result; 
		}

		/// <summary> Multiply this <see cref="Matrix4x4"/> by the given <see cref="Vector4"/>. </summary>
		public static Vector4 operator *(Matrix4x4 lhs, Vector4 vec) {
			Vector4 result = default;
			result.x = lhs.m00 * vec.x + lhs.m10 * vec.y + lhs.m20 * vec.z + lhs.m30 * vec.w;
			result.y = lhs.m01 * vec.x + lhs.m11 * vec.y + lhs.m21 * vec.z + lhs.m31 * vec.w;
			result.z = lhs.m02 * vec.x + lhs.m12 * vec.y + lhs.m22 * vec.z + lhs.m32 * vec.w;
			result.w = lhs.m03 * vec.x + lhs.m13 * vec.y + lhs.m23 * vec.z + lhs.m33 * vec.w;
			return result;
		}
	}
	#endregion
}
