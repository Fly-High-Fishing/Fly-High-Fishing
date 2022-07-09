using UnityEngine;
namespace Utility
{
	static class Swizzles
	{
		public static Vector2 ox(this Vector3 v) { return new Vector2(0, v.x ); }
		public static Vector2 ox(this Vector4 v) { return new Vector2(0, v.x ); }
		public static Vector2 ox(this Vector2 v) { return new Vector2(0, v.x ); }
		public static Vector2 oy(this Vector3 v) { return new Vector2(0, v.y ); }
		public static Vector2 oy(this Vector4 v) { return new Vector2(0, v.y ); }
		public static Vector2 oy(this Vector2 v) { return new Vector2(0, v.y ); }
		public static Vector2 xo(this Vector4 v) { return new Vector2(v.x, 0 ); }
		public static Vector2 xo(this Vector2 v) { return new Vector2(v.x, 0 ); }
		public static Vector2 xo(this Vector3 v) { return new Vector2(v.x, 0 ); }
		public static Vector2 xx(this Vector2 v) { return new Vector2(v.x, v.x ); }
		public static Vector2 xx(this Vector3 v) { return new Vector2(v.x, v.x ); }
		public static Vector2 xx(this Vector4 v) { return new Vector2(v.x, v.x ); }
		public static Vector2 xy(this Vector2 v) { return new Vector2(v.x, v.y ); }
		public static Vector2 xy(this Vector3 v) { return new Vector2(v.x, v.y ); }
		public static Vector2 xy(this Vector4 v) { return new Vector2(v.x, v.y ); }
		public static Vector2 yo(this Vector4 v) { return new Vector2(v.y, 0 ); }
		public static Vector2 yo(this Vector3 v) { return new Vector2(v.y, 0 ); }
		public static Vector2 yo(this Vector2 v) { return new Vector2(v.y, 0 ); }
		public static Vector2 yx(this Vector2 v) { return new Vector2(v.y, v.x ); }
		public static Vector2 yx(this Vector3 v) { return new Vector2(v.y, v.x ); }
		public static Vector2 yx(this Vector4 v) { return new Vector2(v.y, v.x ); }
		public static Vector2 yy(this Vector2 v) { return new Vector2(v.y, v.y ); }
		public static Vector2 yy(this Vector3 v) { return new Vector2(v.y, v.y ); }
		public static Vector2 yy(this Vector4 v) { return new Vector2(v.y, v.y ); }
		public static Vector2 oz(this Vector3 v) { return new Vector2(0, v.z ); }
		public static Vector2 oz(this Vector4 v) { return new Vector2(0, v.z ); }
		public static Vector2 xz(this Vector3 v) { return new Vector2(v.x, v.z ); }
		public static Vector2 xz(this Vector4 v) { return new Vector2(v.x, v.z ); }
		public static Vector2 yz(this Vector3 v) { return new Vector2(v.y, v.z ); }
		public static Vector2 yz(this Vector4 v) { return new Vector2(v.y, v.z ); }
		public static Vector2 zo(this Vector4 v) { return new Vector2(v.z, 0 ); }
		public static Vector2 zo(this Vector3 v) { return new Vector2(v.z, 0 ); }
		public static Vector2 zx(this Vector4 v) { return new Vector2(v.z, v.x ); }
		public static Vector2 zx(this Vector3 v) { return new Vector2(v.z, v.x ); }
		public static Vector2 zy(this Vector4 v) { return new Vector2(v.z, v.y ); }
		public static Vector2 zy(this Vector3 v) { return new Vector2(v.z, v.y ); }
		public static Vector2 zz(this Vector4 v) { return new Vector2(v.z, v.z ); }
		public static Vector2 zz(this Vector3 v) { return new Vector2(v.z, v.z ); }
		public static Vector2 ow(this Vector4 v) { return new Vector2(0, v.w ); }
		public static Vector2 xw(this Vector4 v) { return new Vector2(v.x, v.w ); }
		public static Vector2 yw(this Vector4 v) { return new Vector2(v.y, v.w ); }
		public static Vector2 zw(this Vector4 v) { return new Vector2(v.z, v.w ); }
		public static Vector2 wo(this Vector4 v) { return new Vector2(v.w, 0 ); }
		public static Vector2 wx(this Vector4 v) { return new Vector2(v.w, v.x ); }
		public static Vector2 wy(this Vector4 v) { return new Vector2(v.w, v.y ); }
		public static Vector2 wz(this Vector4 v) { return new Vector2(v.w, v.z ); }
		public static Vector2 ww(this Vector4 v) { return new Vector2(v.w, v.w ); }
		public static Vector3 oox(this Vector2 v) { return new Vector3(0, 0, v.x ); }
		public static Vector3 oox(this Vector3 v) { return new Vector3(0, 0, v.x ); }
		public static Vector3 oox(this Vector4 v) { return new Vector3(0, 0, v.x ); }
		public static Vector3 ooy(this Vector4 v) { return new Vector3(0, 0, v.y ); }
		public static Vector3 ooy(this Vector2 v) { return new Vector3(0, 0, v.y ); }
		public static Vector3 ooy(this Vector3 v) { return new Vector3(0, 0, v.y ); }
		public static Vector3 oxo(this Vector4 v) { return new Vector3(0, v.x, 0 ); }
		public static Vector3 oxo(this Vector3 v) { return new Vector3(0, v.x, 0 ); }
		public static Vector3 oxo(this Vector2 v) { return new Vector3(0, v.x, 0 ); }
		public static Vector3 oxx(this Vector3 v) { return new Vector3(0, v.x, v.x ); }
		public static Vector3 oxx(this Vector4 v) { return new Vector3(0, v.x, v.x ); }
		public static Vector3 oxx(this Vector2 v) { return new Vector3(0, v.x, v.x ); }
		public static Vector3 oxy(this Vector2 v) { return new Vector3(0, v.x, v.y ); }
		public static Vector3 oxy(this Vector4 v) { return new Vector3(0, v.x, v.y ); }
		public static Vector3 oxy(this Vector3 v) { return new Vector3(0, v.x, v.y ); }
		public static Vector3 oyo(this Vector4 v) { return new Vector3(0, v.y, 0 ); }
		public static Vector3 oyo(this Vector3 v) { return new Vector3(0, v.y, 0 ); }
		public static Vector3 oyo(this Vector2 v) { return new Vector3(0, v.y, 0 ); }
		public static Vector3 oyx(this Vector4 v) { return new Vector3(0, v.y, v.x ); }
		public static Vector3 oyx(this Vector3 v) { return new Vector3(0, v.y, v.x ); }
		public static Vector3 oyx(this Vector2 v) { return new Vector3(0, v.y, v.x ); }
		public static Vector3 oyy(this Vector3 v) { return new Vector3(0, v.y, v.y ); }
		public static Vector3 oyy(this Vector2 v) { return new Vector3(0, v.y, v.y ); }
		public static Vector3 oyy(this Vector4 v) { return new Vector3(0, v.y, v.y ); }
		public static Vector3 xoo(this Vector2 v) { return new Vector3(v.x, 0, 0 ); }
		public static Vector3 xoo(this Vector3 v) { return new Vector3(v.x, 0, 0 ); }
		public static Vector3 xoo(this Vector4 v) { return new Vector3(v.x, 0, 0 ); }
		public static Vector3 xox(this Vector2 v) { return new Vector3(v.x, 0, v.x ); }
		public static Vector3 xox(this Vector3 v) { return new Vector3(v.x, 0, v.x ); }
		public static Vector3 xox(this Vector4 v) { return new Vector3(v.x, 0, v.x ); }
		public static Vector3 xoy(this Vector2 v) { return new Vector3(v.x, 0, v.y ); }
		public static Vector3 xoy(this Vector3 v) { return new Vector3(v.x, 0, v.y ); }
		public static Vector3 xoy(this Vector4 v) { return new Vector3(v.x, 0, v.y ); }
		public static Vector3 xxo(this Vector4 v) { return new Vector3(v.x, v.x, 0 ); }
		public static Vector3 xxo(this Vector3 v) { return new Vector3(v.x, v.x, 0 ); }
		public static Vector3 xxo(this Vector2 v) { return new Vector3(v.x, v.x, 0 ); }
		public static Vector3 xxx(this Vector4 v) { return new Vector3(v.x, v.x, v.x ); }
		public static Vector3 xxx(this Vector2 v) { return new Vector3(v.x, v.x, v.x ); }
		public static Vector3 xxx(this Vector3 v) { return new Vector3(v.x, v.x, v.x ); }
		public static Vector3 xxy(this Vector3 v) { return new Vector3(v.x, v.x, v.y ); }
		public static Vector3 xxy(this Vector2 v) { return new Vector3(v.x, v.x, v.y ); }
		public static Vector3 xxy(this Vector4 v) { return new Vector3(v.x, v.x, v.y ); }
		public static Vector3 xyo(this Vector4 v) { return new Vector3(v.x, v.y, 0 ); }
		public static Vector3 xyo(this Vector3 v) { return new Vector3(v.x, v.y, 0 ); }
		public static Vector3 xyo(this Vector2 v) { return new Vector3(v.x, v.y, 0 ); }
		public static Vector3 xyx(this Vector4 v) { return new Vector3(v.x, v.y, v.x ); }
		public static Vector3 xyx(this Vector3 v) { return new Vector3(v.x, v.y, v.x ); }
		public static Vector3 xyx(this Vector2 v) { return new Vector3(v.x, v.y, v.x ); }
		public static Vector3 xyy(this Vector2 v) { return new Vector3(v.x, v.y, v.y ); }
		public static Vector3 xyy(this Vector4 v) { return new Vector3(v.x, v.y, v.y ); }
		public static Vector3 xyy(this Vector3 v) { return new Vector3(v.x, v.y, v.y ); }
		public static Vector3 yoo(this Vector3 v) { return new Vector3(v.y, 0, 0 ); }
		public static Vector3 yoo(this Vector4 v) { return new Vector3(v.y, 0, 0 ); }
		public static Vector3 yoo(this Vector2 v) { return new Vector3(v.y, 0, 0 ); }
		public static Vector3 yox(this Vector2 v) { return new Vector3(v.y, 0, v.x ); }
		public static Vector3 yox(this Vector3 v) { return new Vector3(v.y, 0, v.x ); }
		public static Vector3 yox(this Vector4 v) { return new Vector3(v.y, 0, v.x ); }
		public static Vector3 yoy(this Vector2 v) { return new Vector3(v.y, 0, v.y ); }
		public static Vector3 yoy(this Vector3 v) { return new Vector3(v.y, 0, v.y ); }
		public static Vector3 yoy(this Vector4 v) { return new Vector3(v.y, 0, v.y ); }
		public static Vector3 yxo(this Vector3 v) { return new Vector3(v.y, v.x, 0 ); }
		public static Vector3 yxo(this Vector4 v) { return new Vector3(v.y, v.x, 0 ); }
		public static Vector3 yxo(this Vector2 v) { return new Vector3(v.y, v.x, 0 ); }
		public static Vector3 yxx(this Vector2 v) { return new Vector3(v.y, v.x, v.x ); }
		public static Vector3 yxx(this Vector4 v) { return new Vector3(v.y, v.x, v.x ); }
		public static Vector3 yxx(this Vector3 v) { return new Vector3(v.y, v.x, v.x ); }
		public static Vector3 yxy(this Vector4 v) { return new Vector3(v.y, v.x, v.y ); }
		public static Vector3 yxy(this Vector2 v) { return new Vector3(v.y, v.x, v.y ); }
		public static Vector3 yxy(this Vector3 v) { return new Vector3(v.y, v.x, v.y ); }
		public static Vector3 yyo(this Vector2 v) { return new Vector3(v.y, v.y, 0 ); }
		public static Vector3 yyo(this Vector3 v) { return new Vector3(v.y, v.y, 0 ); }
		public static Vector3 yyo(this Vector4 v) { return new Vector3(v.y, v.y, 0 ); }
		public static Vector3 yyx(this Vector4 v) { return new Vector3(v.y, v.y, v.x ); }
		public static Vector3 yyx(this Vector3 v) { return new Vector3(v.y, v.y, v.x ); }
		public static Vector3 yyx(this Vector2 v) { return new Vector3(v.y, v.y, v.x ); }
		public static Vector3 yyy(this Vector2 v) { return new Vector3(v.y, v.y, v.y ); }
		public static Vector3 yyy(this Vector4 v) { return new Vector3(v.y, v.y, v.y ); }
		public static Vector3 yyy(this Vector3 v) { return new Vector3(v.y, v.y, v.y ); }
		public static Vector3 ooz(this Vector3 v) { return new Vector3(0, 0, v.z ); }
		public static Vector3 ooz(this Vector4 v) { return new Vector3(0, 0, v.z ); }
		public static Vector3 oxz(this Vector4 v) { return new Vector3(0, v.x, v.z ); }
		public static Vector3 oxz(this Vector3 v) { return new Vector3(0, v.x, v.z ); }
		public static Vector3 oyz(this Vector3 v) { return new Vector3(0, v.y, v.z ); }
		public static Vector3 oyz(this Vector4 v) { return new Vector3(0, v.y, v.z ); }
		public static Vector3 ozo(this Vector3 v) { return new Vector3(0, v.z, 0 ); }
		public static Vector3 ozo(this Vector4 v) { return new Vector3(0, v.z, 0 ); }
		public static Vector3 ozx(this Vector4 v) { return new Vector3(0, v.z, v.x ); }
		public static Vector3 ozx(this Vector3 v) { return new Vector3(0, v.z, v.x ); }
		public static Vector3 ozy(this Vector4 v) { return new Vector3(0, v.z, v.y ); }
		public static Vector3 ozy(this Vector3 v) { return new Vector3(0, v.z, v.y ); }
		public static Vector3 ozz(this Vector4 v) { return new Vector3(0, v.z, v.z ); }
		public static Vector3 ozz(this Vector3 v) { return new Vector3(0, v.z, v.z ); }
		public static Vector3 xoz(this Vector3 v) { return new Vector3(v.x, 0, v.z ); }
		public static Vector3 xoz(this Vector4 v) { return new Vector3(v.x, 0, v.z ); }
		public static Vector3 xxz(this Vector4 v) { return new Vector3(v.x, v.x, v.z ); }
		public static Vector3 xxz(this Vector3 v) { return new Vector3(v.x, v.x, v.z ); }
		public static Vector3 xyz(this Vector4 v) { return new Vector3(v.x, v.y, v.z ); }
		public static Vector3 xyz(this Vector3 v) { return new Vector3(v.x, v.y, v.z ); }
		public static Vector3 xzo(this Vector4 v) { return new Vector3(v.x, v.z, 0 ); }
		public static Vector3 xzo(this Vector3 v) { return new Vector3(v.x, v.z, 0 ); }
		public static Vector3 xzx(this Vector4 v) { return new Vector3(v.x, v.z, v.x ); }
		public static Vector3 xzx(this Vector3 v) { return new Vector3(v.x, v.z, v.x ); }
		public static Vector3 xzy(this Vector4 v) { return new Vector3(v.x, v.z, v.y ); }
		public static Vector3 xzy(this Vector3 v) { return new Vector3(v.x, v.z, v.y ); }
		public static Vector3 xzz(this Vector3 v) { return new Vector3(v.x, v.z, v.z ); }
		public static Vector3 xzz(this Vector4 v) { return new Vector3(v.x, v.z, v.z ); }
		public static Vector3 yoz(this Vector4 v) { return new Vector3(v.y, 0, v.z ); }
		public static Vector3 yoz(this Vector3 v) { return new Vector3(v.y, 0, v.z ); }
		public static Vector3 yxz(this Vector3 v) { return new Vector3(v.y, v.x, v.z ); }
		public static Vector3 yxz(this Vector4 v) { return new Vector3(v.y, v.x, v.z ); }
		public static Vector3 yyz(this Vector3 v) { return new Vector3(v.y, v.y, v.z ); }
		public static Vector3 yyz(this Vector4 v) { return new Vector3(v.y, v.y, v.z ); }
		public static Vector3 yzo(this Vector3 v) { return new Vector3(v.y, v.z, 0 ); }
		public static Vector3 yzo(this Vector4 v) { return new Vector3(v.y, v.z, 0 ); }
		public static Vector3 yzx(this Vector4 v) { return new Vector3(v.y, v.z, v.x ); }
		public static Vector3 yzx(this Vector3 v) { return new Vector3(v.y, v.z, v.x ); }
		public static Vector3 yzy(this Vector3 v) { return new Vector3(v.y, v.z, v.y ); }
		public static Vector3 yzy(this Vector4 v) { return new Vector3(v.y, v.z, v.y ); }
		public static Vector3 yzz(this Vector4 v) { return new Vector3(v.y, v.z, v.z ); }
		public static Vector3 yzz(this Vector3 v) { return new Vector3(v.y, v.z, v.z ); }
		public static Vector3 zoo(this Vector4 v) { return new Vector3(v.z, 0, 0 ); }
		public static Vector3 zoo(this Vector3 v) { return new Vector3(v.z, 0, 0 ); }
		public static Vector3 zox(this Vector3 v) { return new Vector3(v.z, 0, v.x ); }
		public static Vector3 zox(this Vector4 v) { return new Vector3(v.z, 0, v.x ); }
		public static Vector3 zoy(this Vector4 v) { return new Vector3(v.z, 0, v.y ); }
		public static Vector3 zoy(this Vector3 v) { return new Vector3(v.z, 0, v.y ); }
		public static Vector3 zoz(this Vector3 v) { return new Vector3(v.z, 0, v.z ); }
		public static Vector3 zoz(this Vector4 v) { return new Vector3(v.z, 0, v.z ); }
		public static Vector3 zxo(this Vector3 v) { return new Vector3(v.z, v.x, 0 ); }
		public static Vector3 zxo(this Vector4 v) { return new Vector3(v.z, v.x, 0 ); }
		public static Vector3 zxx(this Vector3 v) { return new Vector3(v.z, v.x, v.x ); }
		public static Vector3 zxx(this Vector4 v) { return new Vector3(v.z, v.x, v.x ); }
		public static Vector3 zxy(this Vector3 v) { return new Vector3(v.z, v.x, v.y ); }
		public static Vector3 zxy(this Vector4 v) { return new Vector3(v.z, v.x, v.y ); }
		public static Vector3 zxz(this Vector3 v) { return new Vector3(v.z, v.x, v.z ); }
		public static Vector3 zxz(this Vector4 v) { return new Vector3(v.z, v.x, v.z ); }
		public static Vector3 zyo(this Vector3 v) { return new Vector3(v.z, v.y, 0 ); }
		public static Vector3 zyo(this Vector4 v) { return new Vector3(v.z, v.y, 0 ); }
		public static Vector3 zyx(this Vector3 v) { return new Vector3(v.z, v.y, v.x ); }
		public static Vector3 zyx(this Vector4 v) { return new Vector3(v.z, v.y, v.x ); }
		public static Vector3 zyy(this Vector3 v) { return new Vector3(v.z, v.y, v.y ); }
		public static Vector3 zyy(this Vector4 v) { return new Vector3(v.z, v.y, v.y ); }
		public static Vector3 zyz(this Vector3 v) { return new Vector3(v.z, v.y, v.z ); }
		public static Vector3 zyz(this Vector4 v) { return new Vector3(v.z, v.y, v.z ); }
		public static Vector3 zzo(this Vector3 v) { return new Vector3(v.z, v.z, 0 ); }
		public static Vector3 zzo(this Vector4 v) { return new Vector3(v.z, v.z, 0 ); }
		public static Vector3 zzx(this Vector3 v) { return new Vector3(v.z, v.z, v.x ); }
		public static Vector3 zzx(this Vector4 v) { return new Vector3(v.z, v.z, v.x ); }
		public static Vector3 zzy(this Vector4 v) { return new Vector3(v.z, v.z, v.y ); }
		public static Vector3 zzy(this Vector3 v) { return new Vector3(v.z, v.z, v.y ); }
		public static Vector3 zzz(this Vector4 v) { return new Vector3(v.z, v.z, v.z ); }
		public static Vector3 zzz(this Vector3 v) { return new Vector3(v.z, v.z, v.z ); }
		public static Vector3 oow(this Vector4 v) { return new Vector3(0, 0, v.w ); }
		public static Vector3 oxw(this Vector4 v) { return new Vector3(0, v.x, v.w ); }
		public static Vector3 oyw(this Vector4 v) { return new Vector3(0, v.y, v.w ); }
		public static Vector3 ozw(this Vector4 v) { return new Vector3(0, v.z, v.w ); }
		public static Vector3 owo(this Vector4 v) { return new Vector3(0, v.w, 0 ); }
		public static Vector3 owx(this Vector4 v) { return new Vector3(0, v.w, v.x ); }
		public static Vector3 owy(this Vector4 v) { return new Vector3(0, v.w, v.y ); }
		public static Vector3 owz(this Vector4 v) { return new Vector3(0, v.w, v.z ); }
		public static Vector3 oww(this Vector4 v) { return new Vector3(0, v.w, v.w ); }
		public static Vector3 xow(this Vector4 v) { return new Vector3(v.x, 0, v.w ); }
		public static Vector3 xxw(this Vector4 v) { return new Vector3(v.x, v.x, v.w ); }
		public static Vector3 xyw(this Vector4 v) { return new Vector3(v.x, v.y, v.w ); }
		public static Vector3 xzw(this Vector4 v) { return new Vector3(v.x, v.z, v.w ); }
		public static Vector3 xwo(this Vector4 v) { return new Vector3(v.x, v.w, 0 ); }
		public static Vector3 xwx(this Vector4 v) { return new Vector3(v.x, v.w, v.x ); }
		public static Vector3 xwy(this Vector4 v) { return new Vector3(v.x, v.w, v.y ); }
		public static Vector3 xwz(this Vector4 v) { return new Vector3(v.x, v.w, v.z ); }
		public static Vector3 xww(this Vector4 v) { return new Vector3(v.x, v.w, v.w ); }
		public static Vector3 yow(this Vector4 v) { return new Vector3(v.y, 0, v.w ); }
		public static Vector3 yxw(this Vector4 v) { return new Vector3(v.y, v.x, v.w ); }
		public static Vector3 yyw(this Vector4 v) { return new Vector3(v.y, v.y, v.w ); }
		public static Vector3 yzw(this Vector4 v) { return new Vector3(v.y, v.z, v.w ); }
		public static Vector3 ywo(this Vector4 v) { return new Vector3(v.y, v.w, 0 ); }
		public static Vector3 ywx(this Vector4 v) { return new Vector3(v.y, v.w, v.x ); }
		public static Vector3 ywy(this Vector4 v) { return new Vector3(v.y, v.w, v.y ); }
		public static Vector3 ywz(this Vector4 v) { return new Vector3(v.y, v.w, v.z ); }
		public static Vector3 yww(this Vector4 v) { return new Vector3(v.y, v.w, v.w ); }
		public static Vector3 zow(this Vector4 v) { return new Vector3(v.z, 0, v.w ); }
		public static Vector3 zxw(this Vector4 v) { return new Vector3(v.z, v.x, v.w ); }
		public static Vector3 zyw(this Vector4 v) { return new Vector3(v.z, v.y, v.w ); }
		public static Vector3 zzw(this Vector4 v) { return new Vector3(v.z, v.z, v.w ); }
		public static Vector3 zwo(this Vector4 v) { return new Vector3(v.z, v.w, 0 ); }
		public static Vector3 zwx(this Vector4 v) { return new Vector3(v.z, v.w, v.x ); }
		public static Vector3 zwy(this Vector4 v) { return new Vector3(v.z, v.w, v.y ); }
		public static Vector3 zwz(this Vector4 v) { return new Vector3(v.z, v.w, v.z ); }
		public static Vector3 zww(this Vector4 v) { return new Vector3(v.z, v.w, v.w ); }
		public static Vector3 woo(this Vector4 v) { return new Vector3(v.w, 0, 0 ); }
		public static Vector3 wox(this Vector4 v) { return new Vector3(v.w, 0, v.x ); }
		public static Vector3 woy(this Vector4 v) { return new Vector3(v.w, 0, v.y ); }
		public static Vector3 woz(this Vector4 v) { return new Vector3(v.w, 0, v.z ); }
		public static Vector3 wow(this Vector4 v) { return new Vector3(v.w, 0, v.w ); }
		public static Vector3 wxo(this Vector4 v) { return new Vector3(v.w, v.x, 0 ); }
		public static Vector3 wxx(this Vector4 v) { return new Vector3(v.w, v.x, v.x ); }
		public static Vector3 wxy(this Vector4 v) { return new Vector3(v.w, v.x, v.y ); }
		public static Vector3 wxz(this Vector4 v) { return new Vector3(v.w, v.x, v.z ); }
		public static Vector3 wxw(this Vector4 v) { return new Vector3(v.w, v.x, v.w ); }
		public static Vector3 wyo(this Vector4 v) { return new Vector3(v.w, v.y, 0 ); }
		public static Vector3 wyx(this Vector4 v) { return new Vector3(v.w, v.y, v.x ); }
		public static Vector3 wyy(this Vector4 v) { return new Vector3(v.w, v.y, v.y ); }
		public static Vector3 wyz(this Vector4 v) { return new Vector3(v.w, v.y, v.z ); }
		public static Vector3 wyw(this Vector4 v) { return new Vector3(v.w, v.y, v.w ); }
		public static Vector3 wzo(this Vector4 v) { return new Vector3(v.w, v.z, 0 ); }
		public static Vector3 wzx(this Vector4 v) { return new Vector3(v.w, v.z, v.x ); }
		public static Vector3 wzy(this Vector4 v) { return new Vector3(v.w, v.z, v.y ); }
		public static Vector3 wzz(this Vector4 v) { return new Vector3(v.w, v.z, v.z ); }
		public static Vector3 wzw(this Vector4 v) { return new Vector3(v.w, v.z, v.w ); }
		public static Vector3 wwo(this Vector4 v) { return new Vector3(v.w, v.w, 0 ); }
		public static Vector3 wwx(this Vector4 v) { return new Vector3(v.w, v.w, v.x ); }
		public static Vector3 wwy(this Vector4 v) { return new Vector3(v.w, v.w, v.y ); }
		public static Vector3 wwz(this Vector4 v) { return new Vector3(v.w, v.w, v.z ); }
		public static Vector3 www(this Vector4 v) { return new Vector3(v.w, v.w, v.w ); }
		public static Vector4 ooox(this Vector2 v) { return new Vector4(0, 0, 0, v.x ); }
		public static Vector4 ooox(this Vector4 v) { return new Vector4(0, 0, 0, v.x ); }
		public static Vector4 ooox(this Vector3 v) { return new Vector4(0, 0, 0, v.x ); }
		public static Vector4 oooy(this Vector4 v) { return new Vector4(0, 0, 0, v.y ); }
		public static Vector4 oooy(this Vector3 v) { return new Vector4(0, 0, 0, v.y ); }
		public static Vector4 oooy(this Vector2 v) { return new Vector4(0, 0, 0, v.y ); }
		public static Vector4 ooxo(this Vector4 v) { return new Vector4(0, 0, v.x, 0 ); }
		public static Vector4 ooxo(this Vector3 v) { return new Vector4(0, 0, v.x, 0 ); }
		public static Vector4 ooxo(this Vector2 v) { return new Vector4(0, 0, v.x, 0 ); }
		public static Vector4 ooxx(this Vector2 v) { return new Vector4(0, 0, v.x, v.x ); }
		public static Vector4 ooxx(this Vector3 v) { return new Vector4(0, 0, v.x, v.x ); }
		public static Vector4 ooxx(this Vector4 v) { return new Vector4(0, 0, v.x, v.x ); }
		public static Vector4 ooxy(this Vector4 v) { return new Vector4(0, 0, v.x, v.y ); }
		public static Vector4 ooxy(this Vector3 v) { return new Vector4(0, 0, v.x, v.y ); }
		public static Vector4 ooxy(this Vector2 v) { return new Vector4(0, 0, v.x, v.y ); }
		public static Vector4 ooyo(this Vector2 v) { return new Vector4(0, 0, v.y, 0 ); }
		public static Vector4 ooyo(this Vector4 v) { return new Vector4(0, 0, v.y, 0 ); }
		public static Vector4 ooyo(this Vector3 v) { return new Vector4(0, 0, v.y, 0 ); }
		public static Vector4 ooyx(this Vector2 v) { return new Vector4(0, 0, v.y, v.x ); }
		public static Vector4 ooyx(this Vector3 v) { return new Vector4(0, 0, v.y, v.x ); }
		public static Vector4 ooyx(this Vector4 v) { return new Vector4(0, 0, v.y, v.x ); }
		public static Vector4 ooyy(this Vector3 v) { return new Vector4(0, 0, v.y, v.y ); }
		public static Vector4 ooyy(this Vector2 v) { return new Vector4(0, 0, v.y, v.y ); }
		public static Vector4 ooyy(this Vector4 v) { return new Vector4(0, 0, v.y, v.y ); }
		public static Vector4 oxoo(this Vector3 v) { return new Vector4(0, v.x, 0, 0 ); }
		public static Vector4 oxoo(this Vector2 v) { return new Vector4(0, v.x, 0, 0 ); }
		public static Vector4 oxoo(this Vector4 v) { return new Vector4(0, v.x, 0, 0 ); }
		public static Vector4 oxox(this Vector2 v) { return new Vector4(0, v.x, 0, v.x ); }
		public static Vector4 oxox(this Vector3 v) { return new Vector4(0, v.x, 0, v.x ); }
		public static Vector4 oxox(this Vector4 v) { return new Vector4(0, v.x, 0, v.x ); }
		public static Vector4 oxoy(this Vector3 v) { return new Vector4(0, v.x, 0, v.y ); }
		public static Vector4 oxoy(this Vector4 v) { return new Vector4(0, v.x, 0, v.y ); }
		public static Vector4 oxoy(this Vector2 v) { return new Vector4(0, v.x, 0, v.y ); }
		public static Vector4 oxxo(this Vector4 v) { return new Vector4(0, v.x, v.x, 0 ); }
		public static Vector4 oxxo(this Vector2 v) { return new Vector4(0, v.x, v.x, 0 ); }
		public static Vector4 oxxo(this Vector3 v) { return new Vector4(0, v.x, v.x, 0 ); }
		public static Vector4 oxxx(this Vector4 v) { return new Vector4(0, v.x, v.x, v.x ); }
		public static Vector4 oxxx(this Vector3 v) { return new Vector4(0, v.x, v.x, v.x ); }
		public static Vector4 oxxx(this Vector2 v) { return new Vector4(0, v.x, v.x, v.x ); }
		public static Vector4 oxxy(this Vector4 v) { return new Vector4(0, v.x, v.x, v.y ); }
		public static Vector4 oxxy(this Vector3 v) { return new Vector4(0, v.x, v.x, v.y ); }
		public static Vector4 oxxy(this Vector2 v) { return new Vector4(0, v.x, v.x, v.y ); }
		public static Vector4 oxyo(this Vector3 v) { return new Vector4(0, v.x, v.y, 0 ); }
		public static Vector4 oxyo(this Vector2 v) { return new Vector4(0, v.x, v.y, 0 ); }
		public static Vector4 oxyo(this Vector4 v) { return new Vector4(0, v.x, v.y, 0 ); }
		public static Vector4 oxyx(this Vector3 v) { return new Vector4(0, v.x, v.y, v.x ); }
		public static Vector4 oxyx(this Vector2 v) { return new Vector4(0, v.x, v.y, v.x ); }
		public static Vector4 oxyx(this Vector4 v) { return new Vector4(0, v.x, v.y, v.x ); }
		public static Vector4 oxyy(this Vector3 v) { return new Vector4(0, v.x, v.y, v.y ); }
		public static Vector4 oxyy(this Vector2 v) { return new Vector4(0, v.x, v.y, v.y ); }
		public static Vector4 oxyy(this Vector4 v) { return new Vector4(0, v.x, v.y, v.y ); }
		public static Vector4 oyoo(this Vector2 v) { return new Vector4(0, v.y, 0, 0 ); }
		public static Vector4 oyoo(this Vector3 v) { return new Vector4(0, v.y, 0, 0 ); }
		public static Vector4 oyoo(this Vector4 v) { return new Vector4(0, v.y, 0, 0 ); }
		public static Vector4 oyox(this Vector3 v) { return new Vector4(0, v.y, 0, v.x ); }
		public static Vector4 oyox(this Vector4 v) { return new Vector4(0, v.y, 0, v.x ); }
		public static Vector4 oyox(this Vector2 v) { return new Vector4(0, v.y, 0, v.x ); }
		public static Vector4 oyoy(this Vector3 v) { return new Vector4(0, v.y, 0, v.y ); }
		public static Vector4 oyoy(this Vector4 v) { return new Vector4(0, v.y, 0, v.y ); }
		public static Vector4 oyoy(this Vector2 v) { return new Vector4(0, v.y, 0, v.y ); }
		public static Vector4 oyxo(this Vector4 v) { return new Vector4(0, v.y, v.x, 0 ); }
		public static Vector4 oyxo(this Vector3 v) { return new Vector4(0, v.y, v.x, 0 ); }
		public static Vector4 oyxo(this Vector2 v) { return new Vector4(0, v.y, v.x, 0 ); }
		public static Vector4 oyxx(this Vector4 v) { return new Vector4(0, v.y, v.x, v.x ); }
		public static Vector4 oyxx(this Vector3 v) { return new Vector4(0, v.y, v.x, v.x ); }
		public static Vector4 oyxx(this Vector2 v) { return new Vector4(0, v.y, v.x, v.x ); }
		public static Vector4 oyxy(this Vector3 v) { return new Vector4(0, v.y, v.x, v.y ); }
		public static Vector4 oyxy(this Vector2 v) { return new Vector4(0, v.y, v.x, v.y ); }
		public static Vector4 oyxy(this Vector4 v) { return new Vector4(0, v.y, v.x, v.y ); }
		public static Vector4 oyyo(this Vector3 v) { return new Vector4(0, v.y, v.y, 0 ); }
		public static Vector4 oyyo(this Vector2 v) { return new Vector4(0, v.y, v.y, 0 ); }
		public static Vector4 oyyo(this Vector4 v) { return new Vector4(0, v.y, v.y, 0 ); }
		public static Vector4 oyyx(this Vector4 v) { return new Vector4(0, v.y, v.y, v.x ); }
		public static Vector4 oyyx(this Vector2 v) { return new Vector4(0, v.y, v.y, v.x ); }
		public static Vector4 oyyx(this Vector3 v) { return new Vector4(0, v.y, v.y, v.x ); }
		public static Vector4 oyyy(this Vector3 v) { return new Vector4(0, v.y, v.y, v.y ); }
		public static Vector4 oyyy(this Vector2 v) { return new Vector4(0, v.y, v.y, v.y ); }
		public static Vector4 oyyy(this Vector4 v) { return new Vector4(0, v.y, v.y, v.y ); }
		public static Vector4 xooo(this Vector4 v) { return new Vector4(v.x, 0, 0, 0 ); }
		public static Vector4 xooo(this Vector2 v) { return new Vector4(v.x, 0, 0, 0 ); }
		public static Vector4 xooo(this Vector3 v) { return new Vector4(v.x, 0, 0, 0 ); }
		public static Vector4 xoox(this Vector2 v) { return new Vector4(v.x, 0, 0, v.x ); }
		public static Vector4 xoox(this Vector4 v) { return new Vector4(v.x, 0, 0, v.x ); }
		public static Vector4 xoox(this Vector3 v) { return new Vector4(v.x, 0, 0, v.x ); }
		public static Vector4 xooy(this Vector3 v) { return new Vector4(v.x, 0, 0, v.y ); }
		public static Vector4 xooy(this Vector4 v) { return new Vector4(v.x, 0, 0, v.y ); }
		public static Vector4 xooy(this Vector2 v) { return new Vector4(v.x, 0, 0, v.y ); }
		public static Vector4 xoxo(this Vector2 v) { return new Vector4(v.x, 0, v.x, 0 ); }
		public static Vector4 xoxo(this Vector3 v) { return new Vector4(v.x, 0, v.x, 0 ); }
		public static Vector4 xoxo(this Vector4 v) { return new Vector4(v.x, 0, v.x, 0 ); }
		public static Vector4 xoxx(this Vector2 v) { return new Vector4(v.x, 0, v.x, v.x ); }
		public static Vector4 xoxx(this Vector4 v) { return new Vector4(v.x, 0, v.x, v.x ); }
		public static Vector4 xoxx(this Vector3 v) { return new Vector4(v.x, 0, v.x, v.x ); }
		public static Vector4 xoxy(this Vector4 v) { return new Vector4(v.x, 0, v.x, v.y ); }
		public static Vector4 xoxy(this Vector3 v) { return new Vector4(v.x, 0, v.x, v.y ); }
		public static Vector4 xoxy(this Vector2 v) { return new Vector4(v.x, 0, v.x, v.y ); }
		public static Vector4 xoyo(this Vector2 v) { return new Vector4(v.x, 0, v.y, 0 ); }
		public static Vector4 xoyo(this Vector3 v) { return new Vector4(v.x, 0, v.y, 0 ); }
		public static Vector4 xoyo(this Vector4 v) { return new Vector4(v.x, 0, v.y, 0 ); }
		public static Vector4 xoyx(this Vector2 v) { return new Vector4(v.x, 0, v.y, v.x ); }
		public static Vector4 xoyx(this Vector3 v) { return new Vector4(v.x, 0, v.y, v.x ); }
		public static Vector4 xoyx(this Vector4 v) { return new Vector4(v.x, 0, v.y, v.x ); }
		public static Vector4 xoyy(this Vector2 v) { return new Vector4(v.x, 0, v.y, v.y ); }
		public static Vector4 xoyy(this Vector4 v) { return new Vector4(v.x, 0, v.y, v.y ); }
		public static Vector4 xoyy(this Vector3 v) { return new Vector4(v.x, 0, v.y, v.y ); }
		public static Vector4 xxoo(this Vector2 v) { return new Vector4(v.x, v.x, 0, 0 ); }
		public static Vector4 xxoo(this Vector3 v) { return new Vector4(v.x, v.x, 0, 0 ); }
		public static Vector4 xxoo(this Vector4 v) { return new Vector4(v.x, v.x, 0, 0 ); }
		public static Vector4 xxox(this Vector2 v) { return new Vector4(v.x, v.x, 0, v.x ); }
		public static Vector4 xxox(this Vector3 v) { return new Vector4(v.x, v.x, 0, v.x ); }
		public static Vector4 xxox(this Vector4 v) { return new Vector4(v.x, v.x, 0, v.x ); }
		public static Vector4 xxoy(this Vector2 v) { return new Vector4(v.x, v.x, 0, v.y ); }
		public static Vector4 xxoy(this Vector3 v) { return new Vector4(v.x, v.x, 0, v.y ); }
		public static Vector4 xxoy(this Vector4 v) { return new Vector4(v.x, v.x, 0, v.y ); }
		public static Vector4 xxxo(this Vector2 v) { return new Vector4(v.x, v.x, v.x, 0 ); }
		public static Vector4 xxxo(this Vector3 v) { return new Vector4(v.x, v.x, v.x, 0 ); }
		public static Vector4 xxxo(this Vector4 v) { return new Vector4(v.x, v.x, v.x, 0 ); }
		public static Vector4 xxxx(this Vector4 v) { return new Vector4(v.x, v.x, v.x, v.x ); }
		public static Vector4 xxxx(this Vector3 v) { return new Vector4(v.x, v.x, v.x, v.x ); }
		public static Vector4 xxxx(this Vector2 v) { return new Vector4(v.x, v.x, v.x, v.x ); }
		public static Vector4 xxxy(this Vector3 v) { return new Vector4(v.x, v.x, v.x, v.y ); }
		public static Vector4 xxxy(this Vector4 v) { return new Vector4(v.x, v.x, v.x, v.y ); }
		public static Vector4 xxxy(this Vector2 v) { return new Vector4(v.x, v.x, v.x, v.y ); }
		public static Vector4 xxyo(this Vector2 v) { return new Vector4(v.x, v.x, v.y, 0 ); }
		public static Vector4 xxyo(this Vector3 v) { return new Vector4(v.x, v.x, v.y, 0 ); }
		public static Vector4 xxyo(this Vector4 v) { return new Vector4(v.x, v.x, v.y, 0 ); }
		public static Vector4 xxyx(this Vector4 v) { return new Vector4(v.x, v.x, v.y, v.x ); }
		public static Vector4 xxyx(this Vector3 v) { return new Vector4(v.x, v.x, v.y, v.x ); }
		public static Vector4 xxyx(this Vector2 v) { return new Vector4(v.x, v.x, v.y, v.x ); }
		public static Vector4 xxyy(this Vector3 v) { return new Vector4(v.x, v.x, v.y, v.y ); }
		public static Vector4 xxyy(this Vector4 v) { return new Vector4(v.x, v.x, v.y, v.y ); }
		public static Vector4 xxyy(this Vector2 v) { return new Vector4(v.x, v.x, v.y, v.y ); }
		public static Vector4 xyoo(this Vector2 v) { return new Vector4(v.x, v.y, 0, 0 ); }
		public static Vector4 xyoo(this Vector3 v) { return new Vector4(v.x, v.y, 0, 0 ); }
		public static Vector4 xyoo(this Vector4 v) { return new Vector4(v.x, v.y, 0, 0 ); }
		public static Vector4 xyox(this Vector4 v) { return new Vector4(v.x, v.y, 0, v.x ); }
		public static Vector4 xyox(this Vector3 v) { return new Vector4(v.x, v.y, 0, v.x ); }
		public static Vector4 xyox(this Vector2 v) { return new Vector4(v.x, v.y, 0, v.x ); }
		public static Vector4 xyoy(this Vector3 v) { return new Vector4(v.x, v.y, 0, v.y ); }
		public static Vector4 xyoy(this Vector2 v) { return new Vector4(v.x, v.y, 0, v.y ); }
		public static Vector4 xyoy(this Vector4 v) { return new Vector4(v.x, v.y, 0, v.y ); }
		public static Vector4 xyxo(this Vector2 v) { return new Vector4(v.x, v.y, v.x, 0 ); }
		public static Vector4 xyxo(this Vector3 v) { return new Vector4(v.x, v.y, v.x, 0 ); }
		public static Vector4 xyxo(this Vector4 v) { return new Vector4(v.x, v.y, v.x, 0 ); }
		public static Vector4 xyxx(this Vector2 v) { return new Vector4(v.x, v.y, v.x, v.x ); }
		public static Vector4 xyxx(this Vector3 v) { return new Vector4(v.x, v.y, v.x, v.x ); }
		public static Vector4 xyxx(this Vector4 v) { return new Vector4(v.x, v.y, v.x, v.x ); }
		public static Vector4 xyxy(this Vector4 v) { return new Vector4(v.x, v.y, v.x, v.y ); }
		public static Vector4 xyxy(this Vector3 v) { return new Vector4(v.x, v.y, v.x, v.y ); }
		public static Vector4 xyxy(this Vector2 v) { return new Vector4(v.x, v.y, v.x, v.y ); }
		public static Vector4 xyyo(this Vector2 v) { return new Vector4(v.x, v.y, v.y, 0 ); }
		public static Vector4 xyyo(this Vector3 v) { return new Vector4(v.x, v.y, v.y, 0 ); }
		public static Vector4 xyyo(this Vector4 v) { return new Vector4(v.x, v.y, v.y, 0 ); }
		public static Vector4 xyyx(this Vector2 v) { return new Vector4(v.x, v.y, v.y, v.x ); }
		public static Vector4 xyyx(this Vector4 v) { return new Vector4(v.x, v.y, v.y, v.x ); }
		public static Vector4 xyyx(this Vector3 v) { return new Vector4(v.x, v.y, v.y, v.x ); }
		public static Vector4 xyyy(this Vector4 v) { return new Vector4(v.x, v.y, v.y, v.y ); }
		public static Vector4 xyyy(this Vector3 v) { return new Vector4(v.x, v.y, v.y, v.y ); }
		public static Vector4 xyyy(this Vector2 v) { return new Vector4(v.x, v.y, v.y, v.y ); }
		public static Vector4 yooo(this Vector4 v) { return new Vector4(v.y, 0, 0, 0 ); }
		public static Vector4 yooo(this Vector3 v) { return new Vector4(v.y, 0, 0, 0 ); }
		public static Vector4 yooo(this Vector2 v) { return new Vector4(v.y, 0, 0, 0 ); }
		public static Vector4 yoox(this Vector4 v) { return new Vector4(v.y, 0, 0, v.x ); }
		public static Vector4 yoox(this Vector3 v) { return new Vector4(v.y, 0, 0, v.x ); }
		public static Vector4 yoox(this Vector2 v) { return new Vector4(v.y, 0, 0, v.x ); }
		public static Vector4 yooy(this Vector3 v) { return new Vector4(v.y, 0, 0, v.y ); }
		public static Vector4 yooy(this Vector4 v) { return new Vector4(v.y, 0, 0, v.y ); }
		public static Vector4 yooy(this Vector2 v) { return new Vector4(v.y, 0, 0, v.y ); }
		public static Vector4 yoxo(this Vector4 v) { return new Vector4(v.y, 0, v.x, 0 ); }
		public static Vector4 yoxo(this Vector3 v) { return new Vector4(v.y, 0, v.x, 0 ); }
		public static Vector4 yoxo(this Vector2 v) { return new Vector4(v.y, 0, v.x, 0 ); }
		public static Vector4 yoxx(this Vector3 v) { return new Vector4(v.y, 0, v.x, v.x ); }
		public static Vector4 yoxx(this Vector2 v) { return new Vector4(v.y, 0, v.x, v.x ); }
		public static Vector4 yoxx(this Vector4 v) { return new Vector4(v.y, 0, v.x, v.x ); }
		public static Vector4 yoxy(this Vector4 v) { return new Vector4(v.y, 0, v.x, v.y ); }
		public static Vector4 yoxy(this Vector3 v) { return new Vector4(v.y, 0, v.x, v.y ); }
		public static Vector4 yoxy(this Vector2 v) { return new Vector4(v.y, 0, v.x, v.y ); }
		public static Vector4 yoyo(this Vector3 v) { return new Vector4(v.y, 0, v.y, 0 ); }
		public static Vector4 yoyo(this Vector2 v) { return new Vector4(v.y, 0, v.y, 0 ); }
		public static Vector4 yoyo(this Vector4 v) { return new Vector4(v.y, 0, v.y, 0 ); }
		public static Vector4 yoyx(this Vector4 v) { return new Vector4(v.y, 0, v.y, v.x ); }
		public static Vector4 yoyx(this Vector3 v) { return new Vector4(v.y, 0, v.y, v.x ); }
		public static Vector4 yoyx(this Vector2 v) { return new Vector4(v.y, 0, v.y, v.x ); }
		public static Vector4 yoyy(this Vector4 v) { return new Vector4(v.y, 0, v.y, v.y ); }
		public static Vector4 yoyy(this Vector3 v) { return new Vector4(v.y, 0, v.y, v.y ); }
		public static Vector4 yoyy(this Vector2 v) { return new Vector4(v.y, 0, v.y, v.y ); }
		public static Vector4 yxoo(this Vector2 v) { return new Vector4(v.y, v.x, 0, 0 ); }
		public static Vector4 yxoo(this Vector3 v) { return new Vector4(v.y, v.x, 0, 0 ); }
		public static Vector4 yxoo(this Vector4 v) { return new Vector4(v.y, v.x, 0, 0 ); }
		public static Vector4 yxox(this Vector2 v) { return new Vector4(v.y, v.x, 0, v.x ); }
		public static Vector4 yxox(this Vector3 v) { return new Vector4(v.y, v.x, 0, v.x ); }
		public static Vector4 yxox(this Vector4 v) { return new Vector4(v.y, v.x, 0, v.x ); }
		public static Vector4 yxoy(this Vector2 v) { return new Vector4(v.y, v.x, 0, v.y ); }
		public static Vector4 yxoy(this Vector4 v) { return new Vector4(v.y, v.x, 0, v.y ); }
		public static Vector4 yxoy(this Vector3 v) { return new Vector4(v.y, v.x, 0, v.y ); }
		public static Vector4 yxxo(this Vector4 v) { return new Vector4(v.y, v.x, v.x, 0 ); }
		public static Vector4 yxxo(this Vector3 v) { return new Vector4(v.y, v.x, v.x, 0 ); }
		public static Vector4 yxxo(this Vector2 v) { return new Vector4(v.y, v.x, v.x, 0 ); }
		public static Vector4 yxxx(this Vector4 v) { return new Vector4(v.y, v.x, v.x, v.x ); }
		public static Vector4 yxxx(this Vector3 v) { return new Vector4(v.y, v.x, v.x, v.x ); }
		public static Vector4 yxxx(this Vector2 v) { return new Vector4(v.y, v.x, v.x, v.x ); }
		public static Vector4 yxxy(this Vector2 v) { return new Vector4(v.y, v.x, v.x, v.y ); }
		public static Vector4 yxxy(this Vector4 v) { return new Vector4(v.y, v.x, v.x, v.y ); }
		public static Vector4 yxxy(this Vector3 v) { return new Vector4(v.y, v.x, v.x, v.y ); }
		public static Vector4 yxyo(this Vector3 v) { return new Vector4(v.y, v.x, v.y, 0 ); }
		public static Vector4 yxyo(this Vector2 v) { return new Vector4(v.y, v.x, v.y, 0 ); }
		public static Vector4 yxyo(this Vector4 v) { return new Vector4(v.y, v.x, v.y, 0 ); }
		public static Vector4 yxyx(this Vector2 v) { return new Vector4(v.y, v.x, v.y, v.x ); }
		public static Vector4 yxyx(this Vector3 v) { return new Vector4(v.y, v.x, v.y, v.x ); }
		public static Vector4 yxyx(this Vector4 v) { return new Vector4(v.y, v.x, v.y, v.x ); }
		public static Vector4 yxyy(this Vector2 v) { return new Vector4(v.y, v.x, v.y, v.y ); }
		public static Vector4 yxyy(this Vector4 v) { return new Vector4(v.y, v.x, v.y, v.y ); }
		public static Vector4 yxyy(this Vector3 v) { return new Vector4(v.y, v.x, v.y, v.y ); }
		public static Vector4 yyoo(this Vector2 v) { return new Vector4(v.y, v.y, 0, 0 ); }
		public static Vector4 yyoo(this Vector3 v) { return new Vector4(v.y, v.y, 0, 0 ); }
		public static Vector4 yyoo(this Vector4 v) { return new Vector4(v.y, v.y, 0, 0 ); }
		public static Vector4 yyox(this Vector2 v) { return new Vector4(v.y, v.y, 0, v.x ); }
		public static Vector4 yyox(this Vector4 v) { return new Vector4(v.y, v.y, 0, v.x ); }
		public static Vector4 yyox(this Vector3 v) { return new Vector4(v.y, v.y, 0, v.x ); }
		public static Vector4 yyoy(this Vector2 v) { return new Vector4(v.y, v.y, 0, v.y ); }
		public static Vector4 yyoy(this Vector4 v) { return new Vector4(v.y, v.y, 0, v.y ); }
		public static Vector4 yyoy(this Vector3 v) { return new Vector4(v.y, v.y, 0, v.y ); }
		public static Vector4 yyxo(this Vector3 v) { return new Vector4(v.y, v.y, v.x, 0 ); }
		public static Vector4 yyxo(this Vector4 v) { return new Vector4(v.y, v.y, v.x, 0 ); }
		public static Vector4 yyxo(this Vector2 v) { return new Vector4(v.y, v.y, v.x, 0 ); }
		public static Vector4 yyxx(this Vector3 v) { return new Vector4(v.y, v.y, v.x, v.x ); }
		public static Vector4 yyxx(this Vector2 v) { return new Vector4(v.y, v.y, v.x, v.x ); }
		public static Vector4 yyxx(this Vector4 v) { return new Vector4(v.y, v.y, v.x, v.x ); }
		public static Vector4 yyxy(this Vector2 v) { return new Vector4(v.y, v.y, v.x, v.y ); }
		public static Vector4 yyxy(this Vector4 v) { return new Vector4(v.y, v.y, v.x, v.y ); }
		public static Vector4 yyxy(this Vector3 v) { return new Vector4(v.y, v.y, v.x, v.y ); }
		public static Vector4 yyyo(this Vector2 v) { return new Vector4(v.y, v.y, v.y, 0 ); }
		public static Vector4 yyyo(this Vector4 v) { return new Vector4(v.y, v.y, v.y, 0 ); }
		public static Vector4 yyyo(this Vector3 v) { return new Vector4(v.y, v.y, v.y, 0 ); }
		public static Vector4 yyyx(this Vector4 v) { return new Vector4(v.y, v.y, v.y, v.x ); }
		public static Vector4 yyyx(this Vector3 v) { return new Vector4(v.y, v.y, v.y, v.x ); }
		public static Vector4 yyyx(this Vector2 v) { return new Vector4(v.y, v.y, v.y, v.x ); }
		public static Vector4 yyyy(this Vector4 v) { return new Vector4(v.y, v.y, v.y, v.y ); }
		public static Vector4 yyyy(this Vector3 v) { return new Vector4(v.y, v.y, v.y, v.y ); }
		public static Vector4 yyyy(this Vector2 v) { return new Vector4(v.y, v.y, v.y, v.y ); }
		public static Vector4 oooz(this Vector4 v) { return new Vector4(0, 0, 0, v.z ); }
		public static Vector4 oooz(this Vector3 v) { return new Vector4(0, 0, 0, v.z ); }
		public static Vector4 ooxz(this Vector3 v) { return new Vector4(0, 0, v.x, v.z ); }
		public static Vector4 ooxz(this Vector4 v) { return new Vector4(0, 0, v.x, v.z ); }
		public static Vector4 ooyz(this Vector4 v) { return new Vector4(0, 0, v.y, v.z ); }
		public static Vector4 ooyz(this Vector3 v) { return new Vector4(0, 0, v.y, v.z ); }
		public static Vector4 oozo(this Vector3 v) { return new Vector4(0, 0, v.z, 0 ); }
		public static Vector4 oozo(this Vector4 v) { return new Vector4(0, 0, v.z, 0 ); }
		public static Vector4 oozx(this Vector4 v) { return new Vector4(0, 0, v.z, v.x ); }
		public static Vector4 oozx(this Vector3 v) { return new Vector4(0, 0, v.z, v.x ); }
		public static Vector4 oozy(this Vector4 v) { return new Vector4(0, 0, v.z, v.y ); }
		public static Vector4 oozy(this Vector3 v) { return new Vector4(0, 0, v.z, v.y ); }
		public static Vector4 oozz(this Vector3 v) { return new Vector4(0, 0, v.z, v.z ); }
		public static Vector4 oozz(this Vector4 v) { return new Vector4(0, 0, v.z, v.z ); }
		public static Vector4 oxoz(this Vector4 v) { return new Vector4(0, v.x, 0, v.z ); }
		public static Vector4 oxoz(this Vector3 v) { return new Vector4(0, v.x, 0, v.z ); }
		public static Vector4 oxxz(this Vector3 v) { return new Vector4(0, v.x, v.x, v.z ); }
		public static Vector4 oxxz(this Vector4 v) { return new Vector4(0, v.x, v.x, v.z ); }
		public static Vector4 oxyz(this Vector3 v) { return new Vector4(0, v.x, v.y, v.z ); }
		public static Vector4 oxyz(this Vector4 v) { return new Vector4(0, v.x, v.y, v.z ); }
		public static Vector4 oxzo(this Vector4 v) { return new Vector4(0, v.x, v.z, 0 ); }
		public static Vector4 oxzo(this Vector3 v) { return new Vector4(0, v.x, v.z, 0 ); }
		public static Vector4 oxzx(this Vector4 v) { return new Vector4(0, v.x, v.z, v.x ); }
		public static Vector4 oxzx(this Vector3 v) { return new Vector4(0, v.x, v.z, v.x ); }
		public static Vector4 oxzy(this Vector3 v) { return new Vector4(0, v.x, v.z, v.y ); }
		public static Vector4 oxzy(this Vector4 v) { return new Vector4(0, v.x, v.z, v.y ); }
		public static Vector4 oxzz(this Vector4 v) { return new Vector4(0, v.x, v.z, v.z ); }
		public static Vector4 oxzz(this Vector3 v) { return new Vector4(0, v.x, v.z, v.z ); }
		public static Vector4 oyoz(this Vector3 v) { return new Vector4(0, v.y, 0, v.z ); }
		public static Vector4 oyoz(this Vector4 v) { return new Vector4(0, v.y, 0, v.z ); }
		public static Vector4 oyxz(this Vector3 v) { return new Vector4(0, v.y, v.x, v.z ); }
		public static Vector4 oyxz(this Vector4 v) { return new Vector4(0, v.y, v.x, v.z ); }
		public static Vector4 oyyz(this Vector4 v) { return new Vector4(0, v.y, v.y, v.z ); }
		public static Vector4 oyyz(this Vector3 v) { return new Vector4(0, v.y, v.y, v.z ); }
		public static Vector4 oyzo(this Vector4 v) { return new Vector4(0, v.y, v.z, 0 ); }
		public static Vector4 oyzo(this Vector3 v) { return new Vector4(0, v.y, v.z, 0 ); }
		public static Vector4 oyzx(this Vector3 v) { return new Vector4(0, v.y, v.z, v.x ); }
		public static Vector4 oyzx(this Vector4 v) { return new Vector4(0, v.y, v.z, v.x ); }
		public static Vector4 oyzy(this Vector4 v) { return new Vector4(0, v.y, v.z, v.y ); }
		public static Vector4 oyzy(this Vector3 v) { return new Vector4(0, v.y, v.z, v.y ); }
		public static Vector4 oyzz(this Vector4 v) { return new Vector4(0, v.y, v.z, v.z ); }
		public static Vector4 oyzz(this Vector3 v) { return new Vector4(0, v.y, v.z, v.z ); }
		public static Vector4 ozoo(this Vector3 v) { return new Vector4(0, v.z, 0, 0 ); }
		public static Vector4 ozoo(this Vector4 v) { return new Vector4(0, v.z, 0, 0 ); }
		public static Vector4 ozox(this Vector3 v) { return new Vector4(0, v.z, 0, v.x ); }
		public static Vector4 ozox(this Vector4 v) { return new Vector4(0, v.z, 0, v.x ); }
		public static Vector4 ozoy(this Vector3 v) { return new Vector4(0, v.z, 0, v.y ); }
		public static Vector4 ozoy(this Vector4 v) { return new Vector4(0, v.z, 0, v.y ); }
		public static Vector4 ozoz(this Vector4 v) { return new Vector4(0, v.z, 0, v.z ); }
		public static Vector4 ozoz(this Vector3 v) { return new Vector4(0, v.z, 0, v.z ); }
		public static Vector4 ozxo(this Vector4 v) { return new Vector4(0, v.z, v.x, 0 ); }
		public static Vector4 ozxo(this Vector3 v) { return new Vector4(0, v.z, v.x, 0 ); }
		public static Vector4 ozxx(this Vector3 v) { return new Vector4(0, v.z, v.x, v.x ); }
		public static Vector4 ozxx(this Vector4 v) { return new Vector4(0, v.z, v.x, v.x ); }
		public static Vector4 ozxy(this Vector4 v) { return new Vector4(0, v.z, v.x, v.y ); }
		public static Vector4 ozxy(this Vector3 v) { return new Vector4(0, v.z, v.x, v.y ); }
		public static Vector4 ozxz(this Vector4 v) { return new Vector4(0, v.z, v.x, v.z ); }
		public static Vector4 ozxz(this Vector3 v) { return new Vector4(0, v.z, v.x, v.z ); }
		public static Vector4 ozyo(this Vector4 v) { return new Vector4(0, v.z, v.y, 0 ); }
		public static Vector4 ozyo(this Vector3 v) { return new Vector4(0, v.z, v.y, 0 ); }
		public static Vector4 ozyx(this Vector3 v) { return new Vector4(0, v.z, v.y, v.x ); }
		public static Vector4 ozyx(this Vector4 v) { return new Vector4(0, v.z, v.y, v.x ); }
		public static Vector4 ozyy(this Vector3 v) { return new Vector4(0, v.z, v.y, v.y ); }
		public static Vector4 ozyy(this Vector4 v) { return new Vector4(0, v.z, v.y, v.y ); }
		public static Vector4 ozyz(this Vector4 v) { return new Vector4(0, v.z, v.y, v.z ); }
		public static Vector4 ozyz(this Vector3 v) { return new Vector4(0, v.z, v.y, v.z ); }
		public static Vector4 ozzo(this Vector4 v) { return new Vector4(0, v.z, v.z, 0 ); }
		public static Vector4 ozzo(this Vector3 v) { return new Vector4(0, v.z, v.z, 0 ); }
		public static Vector4 ozzx(this Vector4 v) { return new Vector4(0, v.z, v.z, v.x ); }
		public static Vector4 ozzx(this Vector3 v) { return new Vector4(0, v.z, v.z, v.x ); }
		public static Vector4 ozzy(this Vector4 v) { return new Vector4(0, v.z, v.z, v.y ); }
		public static Vector4 ozzy(this Vector3 v) { return new Vector4(0, v.z, v.z, v.y ); }
		public static Vector4 ozzz(this Vector4 v) { return new Vector4(0, v.z, v.z, v.z ); }
		public static Vector4 ozzz(this Vector3 v) { return new Vector4(0, v.z, v.z, v.z ); }
		public static Vector4 xooz(this Vector3 v) { return new Vector4(v.x, 0, 0, v.z ); }
		public static Vector4 xooz(this Vector4 v) { return new Vector4(v.x, 0, 0, v.z ); }
		public static Vector4 xoxz(this Vector4 v) { return new Vector4(v.x, 0, v.x, v.z ); }
		public static Vector4 xoxz(this Vector3 v) { return new Vector4(v.x, 0, v.x, v.z ); }
		public static Vector4 xoyz(this Vector3 v) { return new Vector4(v.x, 0, v.y, v.z ); }
		public static Vector4 xoyz(this Vector4 v) { return new Vector4(v.x, 0, v.y, v.z ); }
		public static Vector4 xozo(this Vector3 v) { return new Vector4(v.x, 0, v.z, 0 ); }
		public static Vector4 xozo(this Vector4 v) { return new Vector4(v.x, 0, v.z, 0 ); }
		public static Vector4 xozx(this Vector4 v) { return new Vector4(v.x, 0, v.z, v.x ); }
		public static Vector4 xozx(this Vector3 v) { return new Vector4(v.x, 0, v.z, v.x ); }
		public static Vector4 xozy(this Vector4 v) { return new Vector4(v.x, 0, v.z, v.y ); }
		public static Vector4 xozy(this Vector3 v) { return new Vector4(v.x, 0, v.z, v.y ); }
		public static Vector4 xozz(this Vector4 v) { return new Vector4(v.x, 0, v.z, v.z ); }
		public static Vector4 xozz(this Vector3 v) { return new Vector4(v.x, 0, v.z, v.z ); }
		public static Vector4 xxoz(this Vector3 v) { return new Vector4(v.x, v.x, 0, v.z ); }
		public static Vector4 xxoz(this Vector4 v) { return new Vector4(v.x, v.x, 0, v.z ); }
		public static Vector4 xxxz(this Vector3 v) { return new Vector4(v.x, v.x, v.x, v.z ); }
		public static Vector4 xxxz(this Vector4 v) { return new Vector4(v.x, v.x, v.x, v.z ); }
		public static Vector4 xxyz(this Vector3 v) { return new Vector4(v.x, v.x, v.y, v.z ); }
		public static Vector4 xxyz(this Vector4 v) { return new Vector4(v.x, v.x, v.y, v.z ); }
		public static Vector4 xxzo(this Vector3 v) { return new Vector4(v.x, v.x, v.z, 0 ); }
		public static Vector4 xxzo(this Vector4 v) { return new Vector4(v.x, v.x, v.z, 0 ); }
		public static Vector4 xxzx(this Vector3 v) { return new Vector4(v.x, v.x, v.z, v.x ); }
		public static Vector4 xxzx(this Vector4 v) { return new Vector4(v.x, v.x, v.z, v.x ); }
		public static Vector4 xxzy(this Vector3 v) { return new Vector4(v.x, v.x, v.z, v.y ); }
		public static Vector4 xxzy(this Vector4 v) { return new Vector4(v.x, v.x, v.z, v.y ); }
		public static Vector4 xxzz(this Vector4 v) { return new Vector4(v.x, v.x, v.z, v.z ); }
		public static Vector4 xxzz(this Vector3 v) { return new Vector4(v.x, v.x, v.z, v.z ); }
		public static Vector4 xyoz(this Vector3 v) { return new Vector4(v.x, v.y, 0, v.z ); }
		public static Vector4 xyoz(this Vector4 v) { return new Vector4(v.x, v.y, 0, v.z ); }
		public static Vector4 xyxz(this Vector3 v) { return new Vector4(v.x, v.y, v.x, v.z ); }
		public static Vector4 xyxz(this Vector4 v) { return new Vector4(v.x, v.y, v.x, v.z ); }
		public static Vector4 xyyz(this Vector3 v) { return new Vector4(v.x, v.y, v.y, v.z ); }
		public static Vector4 xyyz(this Vector4 v) { return new Vector4(v.x, v.y, v.y, v.z ); }
		public static Vector4 xyzo(this Vector4 v) { return new Vector4(v.x, v.y, v.z, 0 ); }
		public static Vector4 xyzo(this Vector3 v) { return new Vector4(v.x, v.y, v.z, 0 ); }
		public static Vector4 xyzx(this Vector4 v) { return new Vector4(v.x, v.y, v.z, v.x ); }
		public static Vector4 xyzx(this Vector3 v) { return new Vector4(v.x, v.y, v.z, v.x ); }
		public static Vector4 xyzy(this Vector3 v) { return new Vector4(v.x, v.y, v.z, v.y ); }
		public static Vector4 xyzy(this Vector4 v) { return new Vector4(v.x, v.y, v.z, v.y ); }
		public static Vector4 xyzz(this Vector3 v) { return new Vector4(v.x, v.y, v.z, v.z ); }
		public static Vector4 xyzz(this Vector4 v) { return new Vector4(v.x, v.y, v.z, v.z ); }
		public static Vector4 xzoo(this Vector4 v) { return new Vector4(v.x, v.z, 0, 0 ); }
		public static Vector4 xzoo(this Vector3 v) { return new Vector4(v.x, v.z, 0, 0 ); }
		public static Vector4 xzox(this Vector4 v) { return new Vector4(v.x, v.z, 0, v.x ); }
		public static Vector4 xzox(this Vector3 v) { return new Vector4(v.x, v.z, 0, v.x ); }
		public static Vector4 xzoy(this Vector4 v) { return new Vector4(v.x, v.z, 0, v.y ); }
		public static Vector4 xzoy(this Vector3 v) { return new Vector4(v.x, v.z, 0, v.y ); }
		public static Vector4 xzoz(this Vector4 v) { return new Vector4(v.x, v.z, 0, v.z ); }
		public static Vector4 xzoz(this Vector3 v) { return new Vector4(v.x, v.z, 0, v.z ); }
		public static Vector4 xzxo(this Vector3 v) { return new Vector4(v.x, v.z, v.x, 0 ); }
		public static Vector4 xzxo(this Vector4 v) { return new Vector4(v.x, v.z, v.x, 0 ); }
		public static Vector4 xzxx(this Vector3 v) { return new Vector4(v.x, v.z, v.x, v.x ); }
		public static Vector4 xzxx(this Vector4 v) { return new Vector4(v.x, v.z, v.x, v.x ); }
		public static Vector4 xzxy(this Vector4 v) { return new Vector4(v.x, v.z, v.x, v.y ); }
		public static Vector4 xzxy(this Vector3 v) { return new Vector4(v.x, v.z, v.x, v.y ); }
		public static Vector4 xzxz(this Vector3 v) { return new Vector4(v.x, v.z, v.x, v.z ); }
		public static Vector4 xzxz(this Vector4 v) { return new Vector4(v.x, v.z, v.x, v.z ); }
		public static Vector4 xzyo(this Vector4 v) { return new Vector4(v.x, v.z, v.y, 0 ); }
		public static Vector4 xzyo(this Vector3 v) { return new Vector4(v.x, v.z, v.y, 0 ); }
		public static Vector4 xzyx(this Vector3 v) { return new Vector4(v.x, v.z, v.y, v.x ); }
		public static Vector4 xzyx(this Vector4 v) { return new Vector4(v.x, v.z, v.y, v.x ); }
		public static Vector4 xzyy(this Vector4 v) { return new Vector4(v.x, v.z, v.y, v.y ); }
		public static Vector4 xzyy(this Vector3 v) { return new Vector4(v.x, v.z, v.y, v.y ); }
		public static Vector4 xzyz(this Vector3 v) { return new Vector4(v.x, v.z, v.y, v.z ); }
		public static Vector4 xzyz(this Vector4 v) { return new Vector4(v.x, v.z, v.y, v.z ); }
		public static Vector4 xzzo(this Vector3 v) { return new Vector4(v.x, v.z, v.z, 0 ); }
		public static Vector4 xzzo(this Vector4 v) { return new Vector4(v.x, v.z, v.z, 0 ); }
		public static Vector4 xzzx(this Vector4 v) { return new Vector4(v.x, v.z, v.z, v.x ); }
		public static Vector4 xzzx(this Vector3 v) { return new Vector4(v.x, v.z, v.z, v.x ); }
		public static Vector4 xzzy(this Vector3 v) { return new Vector4(v.x, v.z, v.z, v.y ); }
		public static Vector4 xzzy(this Vector4 v) { return new Vector4(v.x, v.z, v.z, v.y ); }
		public static Vector4 xzzz(this Vector3 v) { return new Vector4(v.x, v.z, v.z, v.z ); }
		public static Vector4 xzzz(this Vector4 v) { return new Vector4(v.x, v.z, v.z, v.z ); }
		public static Vector4 yooz(this Vector4 v) { return new Vector4(v.y, 0, 0, v.z ); }
		public static Vector4 yooz(this Vector3 v) { return new Vector4(v.y, 0, 0, v.z ); }
		public static Vector4 yoxz(this Vector4 v) { return new Vector4(v.y, 0, v.x, v.z ); }
		public static Vector4 yoxz(this Vector3 v) { return new Vector4(v.y, 0, v.x, v.z ); }
		public static Vector4 yoyz(this Vector3 v) { return new Vector4(v.y, 0, v.y, v.z ); }
		public static Vector4 yoyz(this Vector4 v) { return new Vector4(v.y, 0, v.y, v.z ); }
		public static Vector4 yozo(this Vector4 v) { return new Vector4(v.y, 0, v.z, 0 ); }
		public static Vector4 yozo(this Vector3 v) { return new Vector4(v.y, 0, v.z, 0 ); }
		public static Vector4 yozx(this Vector3 v) { return new Vector4(v.y, 0, v.z, v.x ); }
		public static Vector4 yozx(this Vector4 v) { return new Vector4(v.y, 0, v.z, v.x ); }
		public static Vector4 yozy(this Vector3 v) { return new Vector4(v.y, 0, v.z, v.y ); }
		public static Vector4 yozy(this Vector4 v) { return new Vector4(v.y, 0, v.z, v.y ); }
		public static Vector4 yozz(this Vector4 v) { return new Vector4(v.y, 0, v.z, v.z ); }
		public static Vector4 yozz(this Vector3 v) { return new Vector4(v.y, 0, v.z, v.z ); }
		public static Vector4 yxoz(this Vector4 v) { return new Vector4(v.y, v.x, 0, v.z ); }
		public static Vector4 yxoz(this Vector3 v) { return new Vector4(v.y, v.x, 0, v.z ); }
		public static Vector4 yxxz(this Vector3 v) { return new Vector4(v.y, v.x, v.x, v.z ); }
		public static Vector4 yxxz(this Vector4 v) { return new Vector4(v.y, v.x, v.x, v.z ); }
		public static Vector4 yxyz(this Vector4 v) { return new Vector4(v.y, v.x, v.y, v.z ); }
		public static Vector4 yxyz(this Vector3 v) { return new Vector4(v.y, v.x, v.y, v.z ); }
		public static Vector4 yxzo(this Vector3 v) { return new Vector4(v.y, v.x, v.z, 0 ); }
		public static Vector4 yxzo(this Vector4 v) { return new Vector4(v.y, v.x, v.z, 0 ); }
		public static Vector4 yxzx(this Vector4 v) { return new Vector4(v.y, v.x, v.z, v.x ); }
		public static Vector4 yxzx(this Vector3 v) { return new Vector4(v.y, v.x, v.z, v.x ); }
		public static Vector4 yxzy(this Vector4 v) { return new Vector4(v.y, v.x, v.z, v.y ); }
		public static Vector4 yxzy(this Vector3 v) { return new Vector4(v.y, v.x, v.z, v.y ); }
		public static Vector4 yxzz(this Vector3 v) { return new Vector4(v.y, v.x, v.z, v.z ); }
		public static Vector4 yxzz(this Vector4 v) { return new Vector4(v.y, v.x, v.z, v.z ); }
		public static Vector4 yyoz(this Vector4 v) { return new Vector4(v.y, v.y, 0, v.z ); }
		public static Vector4 yyoz(this Vector3 v) { return new Vector4(v.y, v.y, 0, v.z ); }
		public static Vector4 yyxz(this Vector4 v) { return new Vector4(v.y, v.y, v.x, v.z ); }
		public static Vector4 yyxz(this Vector3 v) { return new Vector4(v.y, v.y, v.x, v.z ); }
		public static Vector4 yyyz(this Vector4 v) { return new Vector4(v.y, v.y, v.y, v.z ); }
		public static Vector4 yyyz(this Vector3 v) { return new Vector4(v.y, v.y, v.y, v.z ); }
		public static Vector4 yyzo(this Vector3 v) { return new Vector4(v.y, v.y, v.z, 0 ); }
		public static Vector4 yyzo(this Vector4 v) { return new Vector4(v.y, v.y, v.z, 0 ); }
		public static Vector4 yyzx(this Vector4 v) { return new Vector4(v.y, v.y, v.z, v.x ); }
		public static Vector4 yyzx(this Vector3 v) { return new Vector4(v.y, v.y, v.z, v.x ); }
		public static Vector4 yyzy(this Vector4 v) { return new Vector4(v.y, v.y, v.z, v.y ); }
		public static Vector4 yyzy(this Vector3 v) { return new Vector4(v.y, v.y, v.z, v.y ); }
		public static Vector4 yyzz(this Vector3 v) { return new Vector4(v.y, v.y, v.z, v.z ); }
		public static Vector4 yyzz(this Vector4 v) { return new Vector4(v.y, v.y, v.z, v.z ); }
		public static Vector4 yzoo(this Vector4 v) { return new Vector4(v.y, v.z, 0, 0 ); }
		public static Vector4 yzoo(this Vector3 v) { return new Vector4(v.y, v.z, 0, 0 ); }
		public static Vector4 yzox(this Vector4 v) { return new Vector4(v.y, v.z, 0, v.x ); }
		public static Vector4 yzox(this Vector3 v) { return new Vector4(v.y, v.z, 0, v.x ); }
		public static Vector4 yzoy(this Vector3 v) { return new Vector4(v.y, v.z, 0, v.y ); }
		public static Vector4 yzoy(this Vector4 v) { return new Vector4(v.y, v.z, 0, v.y ); }
		public static Vector4 yzoz(this Vector4 v) { return new Vector4(v.y, v.z, 0, v.z ); }
		public static Vector4 yzoz(this Vector3 v) { return new Vector4(v.y, v.z, 0, v.z ); }
		public static Vector4 yzxo(this Vector3 v) { return new Vector4(v.y, v.z, v.x, 0 ); }
		public static Vector4 yzxo(this Vector4 v) { return new Vector4(v.y, v.z, v.x, 0 ); }
		public static Vector4 yzxx(this Vector3 v) { return new Vector4(v.y, v.z, v.x, v.x ); }
		public static Vector4 yzxx(this Vector4 v) { return new Vector4(v.y, v.z, v.x, v.x ); }
		public static Vector4 yzxy(this Vector4 v) { return new Vector4(v.y, v.z, v.x, v.y ); }
		public static Vector4 yzxy(this Vector3 v) { return new Vector4(v.y, v.z, v.x, v.y ); }
		public static Vector4 yzxz(this Vector3 v) { return new Vector4(v.y, v.z, v.x, v.z ); }
		public static Vector4 yzxz(this Vector4 v) { return new Vector4(v.y, v.z, v.x, v.z ); }
		public static Vector4 yzyo(this Vector3 v) { return new Vector4(v.y, v.z, v.y, 0 ); }
		public static Vector4 yzyo(this Vector4 v) { return new Vector4(v.y, v.z, v.y, 0 ); }
		public static Vector4 yzyx(this Vector4 v) { return new Vector4(v.y, v.z, v.y, v.x ); }
		public static Vector4 yzyx(this Vector3 v) { return new Vector4(v.y, v.z, v.y, v.x ); }
		public static Vector4 yzyy(this Vector4 v) { return new Vector4(v.y, v.z, v.y, v.y ); }
		public static Vector4 yzyy(this Vector3 v) { return new Vector4(v.y, v.z, v.y, v.y ); }
		public static Vector4 yzyz(this Vector4 v) { return new Vector4(v.y, v.z, v.y, v.z ); }
		public static Vector4 yzyz(this Vector3 v) { return new Vector4(v.y, v.z, v.y, v.z ); }
		public static Vector4 yzzo(this Vector3 v) { return new Vector4(v.y, v.z, v.z, 0 ); }
		public static Vector4 yzzo(this Vector4 v) { return new Vector4(v.y, v.z, v.z, 0 ); }
		public static Vector4 yzzx(this Vector4 v) { return new Vector4(v.y, v.z, v.z, v.x ); }
		public static Vector4 yzzx(this Vector3 v) { return new Vector4(v.y, v.z, v.z, v.x ); }
		public static Vector4 yzzy(this Vector3 v) { return new Vector4(v.y, v.z, v.z, v.y ); }
		public static Vector4 yzzy(this Vector4 v) { return new Vector4(v.y, v.z, v.z, v.y ); }
		public static Vector4 yzzz(this Vector3 v) { return new Vector4(v.y, v.z, v.z, v.z ); }
		public static Vector4 yzzz(this Vector4 v) { return new Vector4(v.y, v.z, v.z, v.z ); }
		public static Vector4 zooo(this Vector4 v) { return new Vector4(v.z, 0, 0, 0 ); }
		public static Vector4 zooo(this Vector3 v) { return new Vector4(v.z, 0, 0, 0 ); }
		public static Vector4 zoox(this Vector4 v) { return new Vector4(v.z, 0, 0, v.x ); }
		public static Vector4 zoox(this Vector3 v) { return new Vector4(v.z, 0, 0, v.x ); }
		public static Vector4 zooy(this Vector3 v) { return new Vector4(v.z, 0, 0, v.y ); }
		public static Vector4 zooy(this Vector4 v) { return new Vector4(v.z, 0, 0, v.y ); }
		public static Vector4 zooz(this Vector3 v) { return new Vector4(v.z, 0, 0, v.z ); }
		public static Vector4 zooz(this Vector4 v) { return new Vector4(v.z, 0, 0, v.z ); }
		public static Vector4 zoxo(this Vector4 v) { return new Vector4(v.z, 0, v.x, 0 ); }
		public static Vector4 zoxo(this Vector3 v) { return new Vector4(v.z, 0, v.x, 0 ); }
		public static Vector4 zoxx(this Vector4 v) { return new Vector4(v.z, 0, v.x, v.x ); }
		public static Vector4 zoxx(this Vector3 v) { return new Vector4(v.z, 0, v.x, v.x ); }
		public static Vector4 zoxy(this Vector4 v) { return new Vector4(v.z, 0, v.x, v.y ); }
		public static Vector4 zoxy(this Vector3 v) { return new Vector4(v.z, 0, v.x, v.y ); }
		public static Vector4 zoxz(this Vector3 v) { return new Vector4(v.z, 0, v.x, v.z ); }
		public static Vector4 zoxz(this Vector4 v) { return new Vector4(v.z, 0, v.x, v.z ); }
		public static Vector4 zoyo(this Vector4 v) { return new Vector4(v.z, 0, v.y, 0 ); }
		public static Vector4 zoyo(this Vector3 v) { return new Vector4(v.z, 0, v.y, 0 ); }
		public static Vector4 zoyx(this Vector4 v) { return new Vector4(v.z, 0, v.y, v.x ); }
		public static Vector4 zoyx(this Vector3 v) { return new Vector4(v.z, 0, v.y, v.x ); }
		public static Vector4 zoyy(this Vector4 v) { return new Vector4(v.z, 0, v.y, v.y ); }
		public static Vector4 zoyy(this Vector3 v) { return new Vector4(v.z, 0, v.y, v.y ); }
		public static Vector4 zoyz(this Vector4 v) { return new Vector4(v.z, 0, v.y, v.z ); }
		public static Vector4 zoyz(this Vector3 v) { return new Vector4(v.z, 0, v.y, v.z ); }
		public static Vector4 zozo(this Vector4 v) { return new Vector4(v.z, 0, v.z, 0 ); }
		public static Vector4 zozo(this Vector3 v) { return new Vector4(v.z, 0, v.z, 0 ); }
		public static Vector4 zozx(this Vector3 v) { return new Vector4(v.z, 0, v.z, v.x ); }
		public static Vector4 zozx(this Vector4 v) { return new Vector4(v.z, 0, v.z, v.x ); }
		public static Vector4 zozy(this Vector3 v) { return new Vector4(v.z, 0, v.z, v.y ); }
		public static Vector4 zozy(this Vector4 v) { return new Vector4(v.z, 0, v.z, v.y ); }
		public static Vector4 zozz(this Vector4 v) { return new Vector4(v.z, 0, v.z, v.z ); }
		public static Vector4 zozz(this Vector3 v) { return new Vector4(v.z, 0, v.z, v.z ); }
		public static Vector4 zxoo(this Vector4 v) { return new Vector4(v.z, v.x, 0, 0 ); }
		public static Vector4 zxoo(this Vector3 v) { return new Vector4(v.z, v.x, 0, 0 ); }
		public static Vector4 zxox(this Vector3 v) { return new Vector4(v.z, v.x, 0, v.x ); }
		public static Vector4 zxox(this Vector4 v) { return new Vector4(v.z, v.x, 0, v.x ); }
		public static Vector4 zxoy(this Vector3 v) { return new Vector4(v.z, v.x, 0, v.y ); }
		public static Vector4 zxoy(this Vector4 v) { return new Vector4(v.z, v.x, 0, v.y ); }
		public static Vector4 zxoz(this Vector4 v) { return new Vector4(v.z, v.x, 0, v.z ); }
		public static Vector4 zxoz(this Vector3 v) { return new Vector4(v.z, v.x, 0, v.z ); }
		public static Vector4 zxxo(this Vector4 v) { return new Vector4(v.z, v.x, v.x, 0 ); }
		public static Vector4 zxxo(this Vector3 v) { return new Vector4(v.z, v.x, v.x, 0 ); }
		public static Vector4 zxxx(this Vector3 v) { return new Vector4(v.z, v.x, v.x, v.x ); }
		public static Vector4 zxxx(this Vector4 v) { return new Vector4(v.z, v.x, v.x, v.x ); }
		public static Vector4 zxxy(this Vector3 v) { return new Vector4(v.z, v.x, v.x, v.y ); }
		public static Vector4 zxxy(this Vector4 v) { return new Vector4(v.z, v.x, v.x, v.y ); }
		public static Vector4 zxxz(this Vector3 v) { return new Vector4(v.z, v.x, v.x, v.z ); }
		public static Vector4 zxxz(this Vector4 v) { return new Vector4(v.z, v.x, v.x, v.z ); }
		public static Vector4 zxyo(this Vector4 v) { return new Vector4(v.z, v.x, v.y, 0 ); }
		public static Vector4 zxyo(this Vector3 v) { return new Vector4(v.z, v.x, v.y, 0 ); }
		public static Vector4 zxyx(this Vector3 v) { return new Vector4(v.z, v.x, v.y, v.x ); }
		public static Vector4 zxyx(this Vector4 v) { return new Vector4(v.z, v.x, v.y, v.x ); }
		public static Vector4 zxyy(this Vector3 v) { return new Vector4(v.z, v.x, v.y, v.y ); }
		public static Vector4 zxyy(this Vector4 v) { return new Vector4(v.z, v.x, v.y, v.y ); }
		public static Vector4 zxyz(this Vector3 v) { return new Vector4(v.z, v.x, v.y, v.z ); }
		public static Vector4 zxyz(this Vector4 v) { return new Vector4(v.z, v.x, v.y, v.z ); }
		public static Vector4 zxzo(this Vector4 v) { return new Vector4(v.z, v.x, v.z, 0 ); }
		public static Vector4 zxzo(this Vector3 v) { return new Vector4(v.z, v.x, v.z, 0 ); }
		public static Vector4 zxzx(this Vector4 v) { return new Vector4(v.z, v.x, v.z, v.x ); }
		public static Vector4 zxzx(this Vector3 v) { return new Vector4(v.z, v.x, v.z, v.x ); }
		public static Vector4 zxzy(this Vector3 v) { return new Vector4(v.z, v.x, v.z, v.y ); }
		public static Vector4 zxzy(this Vector4 v) { return new Vector4(v.z, v.x, v.z, v.y ); }
		public static Vector4 zxzz(this Vector3 v) { return new Vector4(v.z, v.x, v.z, v.z ); }
		public static Vector4 zxzz(this Vector4 v) { return new Vector4(v.z, v.x, v.z, v.z ); }
		public static Vector4 zyoo(this Vector3 v) { return new Vector4(v.z, v.y, 0, 0 ); }
		public static Vector4 zyoo(this Vector4 v) { return new Vector4(v.z, v.y, 0, 0 ); }
		public static Vector4 zyox(this Vector3 v) { return new Vector4(v.z, v.y, 0, v.x ); }
		public static Vector4 zyox(this Vector4 v) { return new Vector4(v.z, v.y, 0, v.x ); }
		public static Vector4 zyoy(this Vector4 v) { return new Vector4(v.z, v.y, 0, v.y ); }
		public static Vector4 zyoy(this Vector3 v) { return new Vector4(v.z, v.y, 0, v.y ); }
		public static Vector4 zyoz(this Vector3 v) { return new Vector4(v.z, v.y, 0, v.z ); }
		public static Vector4 zyoz(this Vector4 v) { return new Vector4(v.z, v.y, 0, v.z ); }
		public static Vector4 zyxo(this Vector3 v) { return new Vector4(v.z, v.y, v.x, 0 ); }
		public static Vector4 zyxo(this Vector4 v) { return new Vector4(v.z, v.y, v.x, 0 ); }
		public static Vector4 zyxx(this Vector3 v) { return new Vector4(v.z, v.y, v.x, v.x ); }
		public static Vector4 zyxx(this Vector4 v) { return new Vector4(v.z, v.y, v.x, v.x ); }
		public static Vector4 zyxy(this Vector3 v) { return new Vector4(v.z, v.y, v.x, v.y ); }
		public static Vector4 zyxy(this Vector4 v) { return new Vector4(v.z, v.y, v.x, v.y ); }
		public static Vector4 zyxz(this Vector3 v) { return new Vector4(v.z, v.y, v.x, v.z ); }
		public static Vector4 zyxz(this Vector4 v) { return new Vector4(v.z, v.y, v.x, v.z ); }
		public static Vector4 zyyo(this Vector4 v) { return new Vector4(v.z, v.y, v.y, 0 ); }
		public static Vector4 zyyo(this Vector3 v) { return new Vector4(v.z, v.y, v.y, 0 ); }
		public static Vector4 zyyx(this Vector3 v) { return new Vector4(v.z, v.y, v.y, v.x ); }
		public static Vector4 zyyx(this Vector4 v) { return new Vector4(v.z, v.y, v.y, v.x ); }
		public static Vector4 zyyy(this Vector3 v) { return new Vector4(v.z, v.y, v.y, v.y ); }
		public static Vector4 zyyy(this Vector4 v) { return new Vector4(v.z, v.y, v.y, v.y ); }
		public static Vector4 zyyz(this Vector4 v) { return new Vector4(v.z, v.y, v.y, v.z ); }
		public static Vector4 zyyz(this Vector3 v) { return new Vector4(v.z, v.y, v.y, v.z ); }
		public static Vector4 zyzo(this Vector4 v) { return new Vector4(v.z, v.y, v.z, 0 ); }
		public static Vector4 zyzo(this Vector3 v) { return new Vector4(v.z, v.y, v.z, 0 ); }
		public static Vector4 zyzx(this Vector3 v) { return new Vector4(v.z, v.y, v.z, v.x ); }
		public static Vector4 zyzx(this Vector4 v) { return new Vector4(v.z, v.y, v.z, v.x ); }
		public static Vector4 zyzy(this Vector4 v) { return new Vector4(v.z, v.y, v.z, v.y ); }
		public static Vector4 zyzy(this Vector3 v) { return new Vector4(v.z, v.y, v.z, v.y ); }
		public static Vector4 zyzz(this Vector3 v) { return new Vector4(v.z, v.y, v.z, v.z ); }
		public static Vector4 zyzz(this Vector4 v) { return new Vector4(v.z, v.y, v.z, v.z ); }
		public static Vector4 zzoo(this Vector4 v) { return new Vector4(v.z, v.z, 0, 0 ); }
		public static Vector4 zzoo(this Vector3 v) { return new Vector4(v.z, v.z, 0, 0 ); }
		public static Vector4 zzox(this Vector3 v) { return new Vector4(v.z, v.z, 0, v.x ); }
		public static Vector4 zzox(this Vector4 v) { return new Vector4(v.z, v.z, 0, v.x ); }
		public static Vector4 zzoy(this Vector3 v) { return new Vector4(v.z, v.z, 0, v.y ); }
		public static Vector4 zzoy(this Vector4 v) { return new Vector4(v.z, v.z, 0, v.y ); }
		public static Vector4 zzoz(this Vector4 v) { return new Vector4(v.z, v.z, 0, v.z ); }
		public static Vector4 zzoz(this Vector3 v) { return new Vector4(v.z, v.z, 0, v.z ); }
		public static Vector4 zzxo(this Vector4 v) { return new Vector4(v.z, v.z, v.x, 0 ); }
		public static Vector4 zzxo(this Vector3 v) { return new Vector4(v.z, v.z, v.x, 0 ); }
		public static Vector4 zzxx(this Vector3 v) { return new Vector4(v.z, v.z, v.x, v.x ); }
		public static Vector4 zzxx(this Vector4 v) { return new Vector4(v.z, v.z, v.x, v.x ); }
		public static Vector4 zzxy(this Vector3 v) { return new Vector4(v.z, v.z, v.x, v.y ); }
		public static Vector4 zzxy(this Vector4 v) { return new Vector4(v.z, v.z, v.x, v.y ); }
		public static Vector4 zzxz(this Vector3 v) { return new Vector4(v.z, v.z, v.x, v.z ); }
		public static Vector4 zzxz(this Vector4 v) { return new Vector4(v.z, v.z, v.x, v.z ); }
		public static Vector4 zzyo(this Vector4 v) { return new Vector4(v.z, v.z, v.y, 0 ); }
		public static Vector4 zzyo(this Vector3 v) { return new Vector4(v.z, v.z, v.y, 0 ); }
		public static Vector4 zzyx(this Vector3 v) { return new Vector4(v.z, v.z, v.y, v.x ); }
		public static Vector4 zzyx(this Vector4 v) { return new Vector4(v.z, v.z, v.y, v.x ); }
		public static Vector4 zzyy(this Vector3 v) { return new Vector4(v.z, v.z, v.y, v.y ); }
		public static Vector4 zzyy(this Vector4 v) { return new Vector4(v.z, v.z, v.y, v.y ); }
		public static Vector4 zzyz(this Vector4 v) { return new Vector4(v.z, v.z, v.y, v.z ); }
		public static Vector4 zzyz(this Vector3 v) { return new Vector4(v.z, v.z, v.y, v.z ); }
		public static Vector4 zzzo(this Vector4 v) { return new Vector4(v.z, v.z, v.z, 0 ); }
		public static Vector4 zzzo(this Vector3 v) { return new Vector4(v.z, v.z, v.z, 0 ); }
		public static Vector4 zzzx(this Vector3 v) { return new Vector4(v.z, v.z, v.z, v.x ); }
		public static Vector4 zzzx(this Vector4 v) { return new Vector4(v.z, v.z, v.z, v.x ); }
		public static Vector4 zzzy(this Vector3 v) { return new Vector4(v.z, v.z, v.z, v.y ); }
		public static Vector4 zzzy(this Vector4 v) { return new Vector4(v.z, v.z, v.z, v.y ); }
		public static Vector4 zzzz(this Vector4 v) { return new Vector4(v.z, v.z, v.z, v.z ); }
		public static Vector4 zzzz(this Vector3 v) { return new Vector4(v.z, v.z, v.z, v.z ); }
		public static Vector4 ooow(this Vector4 v) { return new Vector4(0, 0, 0, v.w ); }
		public static Vector4 ooxw(this Vector4 v) { return new Vector4(0, 0, v.x, v.w ); }
		public static Vector4 ooyw(this Vector4 v) { return new Vector4(0, 0, v.y, v.w ); }
		public static Vector4 oozw(this Vector4 v) { return new Vector4(0, 0, v.z, v.w ); }
		public static Vector4 oowo(this Vector4 v) { return new Vector4(0, 0, v.w, 0 ); }
		public static Vector4 oowx(this Vector4 v) { return new Vector4(0, 0, v.w, v.x ); }
		public static Vector4 oowy(this Vector4 v) { return new Vector4(0, 0, v.w, v.y ); }
		public static Vector4 oowz(this Vector4 v) { return new Vector4(0, 0, v.w, v.z ); }
		public static Vector4 ooww(this Vector4 v) { return new Vector4(0, 0, v.w, v.w ); }
		public static Vector4 oxow(this Vector4 v) { return new Vector4(0, v.x, 0, v.w ); }
		public static Vector4 oxxw(this Vector4 v) { return new Vector4(0, v.x, v.x, v.w ); }
		public static Vector4 oxyw(this Vector4 v) { return new Vector4(0, v.x, v.y, v.w ); }
		public static Vector4 oxzw(this Vector4 v) { return new Vector4(0, v.x, v.z, v.w ); }
		public static Vector4 oxwo(this Vector4 v) { return new Vector4(0, v.x, v.w, 0 ); }
		public static Vector4 oxwx(this Vector4 v) { return new Vector4(0, v.x, v.w, v.x ); }
		public static Vector4 oxwy(this Vector4 v) { return new Vector4(0, v.x, v.w, v.y ); }
		public static Vector4 oxwz(this Vector4 v) { return new Vector4(0, v.x, v.w, v.z ); }
		public static Vector4 oxww(this Vector4 v) { return new Vector4(0, v.x, v.w, v.w ); }
		public static Vector4 oyow(this Vector4 v) { return new Vector4(0, v.y, 0, v.w ); }
		public static Vector4 oyxw(this Vector4 v) { return new Vector4(0, v.y, v.x, v.w ); }
		public static Vector4 oyyw(this Vector4 v) { return new Vector4(0, v.y, v.y, v.w ); }
		public static Vector4 oyzw(this Vector4 v) { return new Vector4(0, v.y, v.z, v.w ); }
		public static Vector4 oywo(this Vector4 v) { return new Vector4(0, v.y, v.w, 0 ); }
		public static Vector4 oywx(this Vector4 v) { return new Vector4(0, v.y, v.w, v.x ); }
		public static Vector4 oywy(this Vector4 v) { return new Vector4(0, v.y, v.w, v.y ); }
		public static Vector4 oywz(this Vector4 v) { return new Vector4(0, v.y, v.w, v.z ); }
		public static Vector4 oyww(this Vector4 v) { return new Vector4(0, v.y, v.w, v.w ); }
		public static Vector4 ozow(this Vector4 v) { return new Vector4(0, v.z, 0, v.w ); }
		public static Vector4 ozxw(this Vector4 v) { return new Vector4(0, v.z, v.x, v.w ); }
		public static Vector4 ozyw(this Vector4 v) { return new Vector4(0, v.z, v.y, v.w ); }
		public static Vector4 ozzw(this Vector4 v) { return new Vector4(0, v.z, v.z, v.w ); }
		public static Vector4 ozwo(this Vector4 v) { return new Vector4(0, v.z, v.w, 0 ); }
		public static Vector4 ozwx(this Vector4 v) { return new Vector4(0, v.z, v.w, v.x ); }
		public static Vector4 ozwy(this Vector4 v) { return new Vector4(0, v.z, v.w, v.y ); }
		public static Vector4 ozwz(this Vector4 v) { return new Vector4(0, v.z, v.w, v.z ); }
		public static Vector4 ozww(this Vector4 v) { return new Vector4(0, v.z, v.w, v.w ); }
		public static Vector4 owoo(this Vector4 v) { return new Vector4(0, v.w, 0, 0 ); }
		public static Vector4 owox(this Vector4 v) { return new Vector4(0, v.w, 0, v.x ); }
		public static Vector4 owoy(this Vector4 v) { return new Vector4(0, v.w, 0, v.y ); }
		public static Vector4 owoz(this Vector4 v) { return new Vector4(0, v.w, 0, v.z ); }
		public static Vector4 owow(this Vector4 v) { return new Vector4(0, v.w, 0, v.w ); }
		public static Vector4 owxo(this Vector4 v) { return new Vector4(0, v.w, v.x, 0 ); }
		public static Vector4 owxx(this Vector4 v) { return new Vector4(0, v.w, v.x, v.x ); }
		public static Vector4 owxy(this Vector4 v) { return new Vector4(0, v.w, v.x, v.y ); }
		public static Vector4 owxz(this Vector4 v) { return new Vector4(0, v.w, v.x, v.z ); }
		public static Vector4 owxw(this Vector4 v) { return new Vector4(0, v.w, v.x, v.w ); }
		public static Vector4 owyo(this Vector4 v) { return new Vector4(0, v.w, v.y, 0 ); }
		public static Vector4 owyx(this Vector4 v) { return new Vector4(0, v.w, v.y, v.x ); }
		public static Vector4 owyy(this Vector4 v) { return new Vector4(0, v.w, v.y, v.y ); }
		public static Vector4 owyz(this Vector4 v) { return new Vector4(0, v.w, v.y, v.z ); }
		public static Vector4 owyw(this Vector4 v) { return new Vector4(0, v.w, v.y, v.w ); }
		public static Vector4 owzo(this Vector4 v) { return new Vector4(0, v.w, v.z, 0 ); }
		public static Vector4 owzx(this Vector4 v) { return new Vector4(0, v.w, v.z, v.x ); }
		public static Vector4 owzy(this Vector4 v) { return new Vector4(0, v.w, v.z, v.y ); }
		public static Vector4 owzz(this Vector4 v) { return new Vector4(0, v.w, v.z, v.z ); }
		public static Vector4 owzw(this Vector4 v) { return new Vector4(0, v.w, v.z, v.w ); }
		public static Vector4 owwo(this Vector4 v) { return new Vector4(0, v.w, v.w, 0 ); }
		public static Vector4 owwx(this Vector4 v) { return new Vector4(0, v.w, v.w, v.x ); }
		public static Vector4 owwy(this Vector4 v) { return new Vector4(0, v.w, v.w, v.y ); }
		public static Vector4 owwz(this Vector4 v) { return new Vector4(0, v.w, v.w, v.z ); }
		public static Vector4 owww(this Vector4 v) { return new Vector4(0, v.w, v.w, v.w ); }
		public static Vector4 xoow(this Vector4 v) { return new Vector4(v.x, 0, 0, v.w ); }
		public static Vector4 xoxw(this Vector4 v) { return new Vector4(v.x, 0, v.x, v.w ); }
		public static Vector4 xoyw(this Vector4 v) { return new Vector4(v.x, 0, v.y, v.w ); }
		public static Vector4 xozw(this Vector4 v) { return new Vector4(v.x, 0, v.z, v.w ); }
		public static Vector4 xowo(this Vector4 v) { return new Vector4(v.x, 0, v.w, 0 ); }
		public static Vector4 xowx(this Vector4 v) { return new Vector4(v.x, 0, v.w, v.x ); }
		public static Vector4 xowy(this Vector4 v) { return new Vector4(v.x, 0, v.w, v.y ); }
		public static Vector4 xowz(this Vector4 v) { return new Vector4(v.x, 0, v.w, v.z ); }
		public static Vector4 xoww(this Vector4 v) { return new Vector4(v.x, 0, v.w, v.w ); }
		public static Vector4 xxow(this Vector4 v) { return new Vector4(v.x, v.x, 0, v.w ); }
		public static Vector4 xxxw(this Vector4 v) { return new Vector4(v.x, v.x, v.x, v.w ); }
		public static Vector4 xxyw(this Vector4 v) { return new Vector4(v.x, v.x, v.y, v.w ); }
		public static Vector4 xxzw(this Vector4 v) { return new Vector4(v.x, v.x, v.z, v.w ); }
		public static Vector4 xxwo(this Vector4 v) { return new Vector4(v.x, v.x, v.w, 0 ); }
		public static Vector4 xxwx(this Vector4 v) { return new Vector4(v.x, v.x, v.w, v.x ); }
		public static Vector4 xxwy(this Vector4 v) { return new Vector4(v.x, v.x, v.w, v.y ); }
		public static Vector4 xxwz(this Vector4 v) { return new Vector4(v.x, v.x, v.w, v.z ); }
		public static Vector4 xxww(this Vector4 v) { return new Vector4(v.x, v.x, v.w, v.w ); }
		public static Vector4 xyow(this Vector4 v) { return new Vector4(v.x, v.y, 0, v.w ); }
		public static Vector4 xyxw(this Vector4 v) { return new Vector4(v.x, v.y, v.x, v.w ); }
		public static Vector4 xyyw(this Vector4 v) { return new Vector4(v.x, v.y, v.y, v.w ); }
		public static Vector4 xyzw(this Vector4 v) { return new Vector4(v.x, v.y, v.z, v.w ); }
		public static Vector4 xywo(this Vector4 v) { return new Vector4(v.x, v.y, v.w, 0 ); }
		public static Vector4 xywx(this Vector4 v) { return new Vector4(v.x, v.y, v.w, v.x ); }
		public static Vector4 xywy(this Vector4 v) { return new Vector4(v.x, v.y, v.w, v.y ); }
		public static Vector4 xywz(this Vector4 v) { return new Vector4(v.x, v.y, v.w, v.z ); }
		public static Vector4 xyww(this Vector4 v) { return new Vector4(v.x, v.y, v.w, v.w ); }
		public static Vector4 xzow(this Vector4 v) { return new Vector4(v.x, v.z, 0, v.w ); }
		public static Vector4 xzxw(this Vector4 v) { return new Vector4(v.x, v.z, v.x, v.w ); }
		public static Vector4 xzyw(this Vector4 v) { return new Vector4(v.x, v.z, v.y, v.w ); }
		public static Vector4 xzzw(this Vector4 v) { return new Vector4(v.x, v.z, v.z, v.w ); }
		public static Vector4 xzwo(this Vector4 v) { return new Vector4(v.x, v.z, v.w, 0 ); }
		public static Vector4 xzwx(this Vector4 v) { return new Vector4(v.x, v.z, v.w, v.x ); }
		public static Vector4 xzwy(this Vector4 v) { return new Vector4(v.x, v.z, v.w, v.y ); }
		public static Vector4 xzwz(this Vector4 v) { return new Vector4(v.x, v.z, v.w, v.z ); }
		public static Vector4 xzww(this Vector4 v) { return new Vector4(v.x, v.z, v.w, v.w ); }
		public static Vector4 xwoo(this Vector4 v) { return new Vector4(v.x, v.w, 0, 0 ); }
		public static Vector4 xwox(this Vector4 v) { return new Vector4(v.x, v.w, 0, v.x ); }
		public static Vector4 xwoy(this Vector4 v) { return new Vector4(v.x, v.w, 0, v.y ); }
		public static Vector4 xwoz(this Vector4 v) { return new Vector4(v.x, v.w, 0, v.z ); }
		public static Vector4 xwow(this Vector4 v) { return new Vector4(v.x, v.w, 0, v.w ); }
		public static Vector4 xwxo(this Vector4 v) { return new Vector4(v.x, v.w, v.x, 0 ); }
		public static Vector4 xwxx(this Vector4 v) { return new Vector4(v.x, v.w, v.x, v.x ); }
		public static Vector4 xwxy(this Vector4 v) { return new Vector4(v.x, v.w, v.x, v.y ); }
		public static Vector4 xwxz(this Vector4 v) { return new Vector4(v.x, v.w, v.x, v.z ); }
		public static Vector4 xwxw(this Vector4 v) { return new Vector4(v.x, v.w, v.x, v.w ); }
		public static Vector4 xwyo(this Vector4 v) { return new Vector4(v.x, v.w, v.y, 0 ); }
		public static Vector4 xwyx(this Vector4 v) { return new Vector4(v.x, v.w, v.y, v.x ); }
		public static Vector4 xwyy(this Vector4 v) { return new Vector4(v.x, v.w, v.y, v.y ); }
		public static Vector4 xwyz(this Vector4 v) { return new Vector4(v.x, v.w, v.y, v.z ); }
		public static Vector4 xwyw(this Vector4 v) { return new Vector4(v.x, v.w, v.y, v.w ); }
		public static Vector4 xwzo(this Vector4 v) { return new Vector4(v.x, v.w, v.z, 0 ); }
		public static Vector4 xwzx(this Vector4 v) { return new Vector4(v.x, v.w, v.z, v.x ); }
		public static Vector4 xwzy(this Vector4 v) { return new Vector4(v.x, v.w, v.z, v.y ); }
		public static Vector4 xwzz(this Vector4 v) { return new Vector4(v.x, v.w, v.z, v.z ); }
		public static Vector4 xwzw(this Vector4 v) { return new Vector4(v.x, v.w, v.z, v.w ); }
		public static Vector4 xwwo(this Vector4 v) { return new Vector4(v.x, v.w, v.w, 0 ); }
		public static Vector4 xwwx(this Vector4 v) { return new Vector4(v.x, v.w, v.w, v.x ); }
		public static Vector4 xwwy(this Vector4 v) { return new Vector4(v.x, v.w, v.w, v.y ); }
		public static Vector4 xwwz(this Vector4 v) { return new Vector4(v.x, v.w, v.w, v.z ); }
		public static Vector4 xwww(this Vector4 v) { return new Vector4(v.x, v.w, v.w, v.w ); }
		public static Vector4 yoow(this Vector4 v) { return new Vector4(v.y, 0, 0, v.w ); }
		public static Vector4 yoxw(this Vector4 v) { return new Vector4(v.y, 0, v.x, v.w ); }
		public static Vector4 yoyw(this Vector4 v) { return new Vector4(v.y, 0, v.y, v.w ); }
		public static Vector4 yozw(this Vector4 v) { return new Vector4(v.y, 0, v.z, v.w ); }
		public static Vector4 yowo(this Vector4 v) { return new Vector4(v.y, 0, v.w, 0 ); }
		public static Vector4 yowx(this Vector4 v) { return new Vector4(v.y, 0, v.w, v.x ); }
		public static Vector4 yowy(this Vector4 v) { return new Vector4(v.y, 0, v.w, v.y ); }
		public static Vector4 yowz(this Vector4 v) { return new Vector4(v.y, 0, v.w, v.z ); }
		public static Vector4 yoww(this Vector4 v) { return new Vector4(v.y, 0, v.w, v.w ); }
		public static Vector4 yxow(this Vector4 v) { return new Vector4(v.y, v.x, 0, v.w ); }
		public static Vector4 yxxw(this Vector4 v) { return new Vector4(v.y, v.x, v.x, v.w ); }
		public static Vector4 yxyw(this Vector4 v) { return new Vector4(v.y, v.x, v.y, v.w ); }
		public static Vector4 yxzw(this Vector4 v) { return new Vector4(v.y, v.x, v.z, v.w ); }
		public static Vector4 yxwo(this Vector4 v) { return new Vector4(v.y, v.x, v.w, 0 ); }
		public static Vector4 yxwx(this Vector4 v) { return new Vector4(v.y, v.x, v.w, v.x ); }
		public static Vector4 yxwy(this Vector4 v) { return new Vector4(v.y, v.x, v.w, v.y ); }
		public static Vector4 yxwz(this Vector4 v) { return new Vector4(v.y, v.x, v.w, v.z ); }
		public static Vector4 yxww(this Vector4 v) { return new Vector4(v.y, v.x, v.w, v.w ); }
		public static Vector4 yyow(this Vector4 v) { return new Vector4(v.y, v.y, 0, v.w ); }
		public static Vector4 yyxw(this Vector4 v) { return new Vector4(v.y, v.y, v.x, v.w ); }
		public static Vector4 yyyw(this Vector4 v) { return new Vector4(v.y, v.y, v.y, v.w ); }
		public static Vector4 yyzw(this Vector4 v) { return new Vector4(v.y, v.y, v.z, v.w ); }
		public static Vector4 yywo(this Vector4 v) { return new Vector4(v.y, v.y, v.w, 0 ); }
		public static Vector4 yywx(this Vector4 v) { return new Vector4(v.y, v.y, v.w, v.x ); }
		public static Vector4 yywy(this Vector4 v) { return new Vector4(v.y, v.y, v.w, v.y ); }
		public static Vector4 yywz(this Vector4 v) { return new Vector4(v.y, v.y, v.w, v.z ); }
		public static Vector4 yyww(this Vector4 v) { return new Vector4(v.y, v.y, v.w, v.w ); }
		public static Vector4 yzow(this Vector4 v) { return new Vector4(v.y, v.z, 0, v.w ); }
		public static Vector4 yzxw(this Vector4 v) { return new Vector4(v.y, v.z, v.x, v.w ); }
		public static Vector4 yzyw(this Vector4 v) { return new Vector4(v.y, v.z, v.y, v.w ); }
		public static Vector4 yzzw(this Vector4 v) { return new Vector4(v.y, v.z, v.z, v.w ); }
		public static Vector4 yzwo(this Vector4 v) { return new Vector4(v.y, v.z, v.w, 0 ); }
		public static Vector4 yzwx(this Vector4 v) { return new Vector4(v.y, v.z, v.w, v.x ); }
		public static Vector4 yzwy(this Vector4 v) { return new Vector4(v.y, v.z, v.w, v.y ); }
		public static Vector4 yzwz(this Vector4 v) { return new Vector4(v.y, v.z, v.w, v.z ); }
		public static Vector4 yzww(this Vector4 v) { return new Vector4(v.y, v.z, v.w, v.w ); }
		public static Vector4 ywoo(this Vector4 v) { return new Vector4(v.y, v.w, 0, 0 ); }
		public static Vector4 ywox(this Vector4 v) { return new Vector4(v.y, v.w, 0, v.x ); }
		public static Vector4 ywoy(this Vector4 v) { return new Vector4(v.y, v.w, 0, v.y ); }
		public static Vector4 ywoz(this Vector4 v) { return new Vector4(v.y, v.w, 0, v.z ); }
		public static Vector4 ywow(this Vector4 v) { return new Vector4(v.y, v.w, 0, v.w ); }
		public static Vector4 ywxo(this Vector4 v) { return new Vector4(v.y, v.w, v.x, 0 ); }
		public static Vector4 ywxx(this Vector4 v) { return new Vector4(v.y, v.w, v.x, v.x ); }
		public static Vector4 ywxy(this Vector4 v) { return new Vector4(v.y, v.w, v.x, v.y ); }
		public static Vector4 ywxz(this Vector4 v) { return new Vector4(v.y, v.w, v.x, v.z ); }
		public static Vector4 ywxw(this Vector4 v) { return new Vector4(v.y, v.w, v.x, v.w ); }
		public static Vector4 ywyo(this Vector4 v) { return new Vector4(v.y, v.w, v.y, 0 ); }
		public static Vector4 ywyx(this Vector4 v) { return new Vector4(v.y, v.w, v.y, v.x ); }
		public static Vector4 ywyy(this Vector4 v) { return new Vector4(v.y, v.w, v.y, v.y ); }
		public static Vector4 ywyz(this Vector4 v) { return new Vector4(v.y, v.w, v.y, v.z ); }
		public static Vector4 ywyw(this Vector4 v) { return new Vector4(v.y, v.w, v.y, v.w ); }
		public static Vector4 ywzo(this Vector4 v) { return new Vector4(v.y, v.w, v.z, 0 ); }
		public static Vector4 ywzx(this Vector4 v) { return new Vector4(v.y, v.w, v.z, v.x ); }
		public static Vector4 ywzy(this Vector4 v) { return new Vector4(v.y, v.w, v.z, v.y ); }
		public static Vector4 ywzz(this Vector4 v) { return new Vector4(v.y, v.w, v.z, v.z ); }
		public static Vector4 ywzw(this Vector4 v) { return new Vector4(v.y, v.w, v.z, v.w ); }
		public static Vector4 ywwo(this Vector4 v) { return new Vector4(v.y, v.w, v.w, 0 ); }
		public static Vector4 ywwx(this Vector4 v) { return new Vector4(v.y, v.w, v.w, v.x ); }
		public static Vector4 ywwy(this Vector4 v) { return new Vector4(v.y, v.w, v.w, v.y ); }
		public static Vector4 ywwz(this Vector4 v) { return new Vector4(v.y, v.w, v.w, v.z ); }
		public static Vector4 ywww(this Vector4 v) { return new Vector4(v.y, v.w, v.w, v.w ); }
		public static Vector4 zoow(this Vector4 v) { return new Vector4(v.z, 0, 0, v.w ); }
		public static Vector4 zoxw(this Vector4 v) { return new Vector4(v.z, 0, v.x, v.w ); }
		public static Vector4 zoyw(this Vector4 v) { return new Vector4(v.z, 0, v.y, v.w ); }
		public static Vector4 zozw(this Vector4 v) { return new Vector4(v.z, 0, v.z, v.w ); }
		public static Vector4 zowo(this Vector4 v) { return new Vector4(v.z, 0, v.w, 0 ); }
		public static Vector4 zowx(this Vector4 v) { return new Vector4(v.z, 0, v.w, v.x ); }
		public static Vector4 zowy(this Vector4 v) { return new Vector4(v.z, 0, v.w, v.y ); }
		public static Vector4 zowz(this Vector4 v) { return new Vector4(v.z, 0, v.w, v.z ); }
		public static Vector4 zoww(this Vector4 v) { return new Vector4(v.z, 0, v.w, v.w ); }
		public static Vector4 zxow(this Vector4 v) { return new Vector4(v.z, v.x, 0, v.w ); }
		public static Vector4 zxxw(this Vector4 v) { return new Vector4(v.z, v.x, v.x, v.w ); }
		public static Vector4 zxyw(this Vector4 v) { return new Vector4(v.z, v.x, v.y, v.w ); }
		public static Vector4 zxzw(this Vector4 v) { return new Vector4(v.z, v.x, v.z, v.w ); }
		public static Vector4 zxwo(this Vector4 v) { return new Vector4(v.z, v.x, v.w, 0 ); }
		public static Vector4 zxwx(this Vector4 v) { return new Vector4(v.z, v.x, v.w, v.x ); }
		public static Vector4 zxwy(this Vector4 v) { return new Vector4(v.z, v.x, v.w, v.y ); }
		public static Vector4 zxwz(this Vector4 v) { return new Vector4(v.z, v.x, v.w, v.z ); }
		public static Vector4 zxww(this Vector4 v) { return new Vector4(v.z, v.x, v.w, v.w ); }
		public static Vector4 zyow(this Vector4 v) { return new Vector4(v.z, v.y, 0, v.w ); }
		public static Vector4 zyxw(this Vector4 v) { return new Vector4(v.z, v.y, v.x, v.w ); }
		public static Vector4 zyyw(this Vector4 v) { return new Vector4(v.z, v.y, v.y, v.w ); }
		public static Vector4 zyzw(this Vector4 v) { return new Vector4(v.z, v.y, v.z, v.w ); }
		public static Vector4 zywo(this Vector4 v) { return new Vector4(v.z, v.y, v.w, 0 ); }
		public static Vector4 zywx(this Vector4 v) { return new Vector4(v.z, v.y, v.w, v.x ); }
		public static Vector4 zywy(this Vector4 v) { return new Vector4(v.z, v.y, v.w, v.y ); }
		public static Vector4 zywz(this Vector4 v) { return new Vector4(v.z, v.y, v.w, v.z ); }
		public static Vector4 zyww(this Vector4 v) { return new Vector4(v.z, v.y, v.w, v.w ); }
		public static Vector4 zzow(this Vector4 v) { return new Vector4(v.z, v.z, 0, v.w ); }
		public static Vector4 zzxw(this Vector4 v) { return new Vector4(v.z, v.z, v.x, v.w ); }
		public static Vector4 zzyw(this Vector4 v) { return new Vector4(v.z, v.z, v.y, v.w ); }
		public static Vector4 zzzw(this Vector4 v) { return new Vector4(v.z, v.z, v.z, v.w ); }
		public static Vector4 zzwo(this Vector4 v) { return new Vector4(v.z, v.z, v.w, 0 ); }
		public static Vector4 zzwx(this Vector4 v) { return new Vector4(v.z, v.z, v.w, v.x ); }
		public static Vector4 zzwy(this Vector4 v) { return new Vector4(v.z, v.z, v.w, v.y ); }
		public static Vector4 zzwz(this Vector4 v) { return new Vector4(v.z, v.z, v.w, v.z ); }
		public static Vector4 zzww(this Vector4 v) { return new Vector4(v.z, v.z, v.w, v.w ); }
		public static Vector4 zwoo(this Vector4 v) { return new Vector4(v.z, v.w, 0, 0 ); }
		public static Vector4 zwox(this Vector4 v) { return new Vector4(v.z, v.w, 0, v.x ); }
		public static Vector4 zwoy(this Vector4 v) { return new Vector4(v.z, v.w, 0, v.y ); }
		public static Vector4 zwoz(this Vector4 v) { return new Vector4(v.z, v.w, 0, v.z ); }
		public static Vector4 zwow(this Vector4 v) { return new Vector4(v.z, v.w, 0, v.w ); }
		public static Vector4 zwxo(this Vector4 v) { return new Vector4(v.z, v.w, v.x, 0 ); }
		public static Vector4 zwxx(this Vector4 v) { return new Vector4(v.z, v.w, v.x, v.x ); }
		public static Vector4 zwxy(this Vector4 v) { return new Vector4(v.z, v.w, v.x, v.y ); }
		public static Vector4 zwxz(this Vector4 v) { return new Vector4(v.z, v.w, v.x, v.z ); }
		public static Vector4 zwxw(this Vector4 v) { return new Vector4(v.z, v.w, v.x, v.w ); }
		public static Vector4 zwyo(this Vector4 v) { return new Vector4(v.z, v.w, v.y, 0 ); }
		public static Vector4 zwyx(this Vector4 v) { return new Vector4(v.z, v.w, v.y, v.x ); }
		public static Vector4 zwyy(this Vector4 v) { return new Vector4(v.z, v.w, v.y, v.y ); }
		public static Vector4 zwyz(this Vector4 v) { return new Vector4(v.z, v.w, v.y, v.z ); }
		public static Vector4 zwyw(this Vector4 v) { return new Vector4(v.z, v.w, v.y, v.w ); }
		public static Vector4 zwzo(this Vector4 v) { return new Vector4(v.z, v.w, v.z, 0 ); }
		public static Vector4 zwzx(this Vector4 v) { return new Vector4(v.z, v.w, v.z, v.x ); }
		public static Vector4 zwzy(this Vector4 v) { return new Vector4(v.z, v.w, v.z, v.y ); }
		public static Vector4 zwzz(this Vector4 v) { return new Vector4(v.z, v.w, v.z, v.z ); }
		public static Vector4 zwzw(this Vector4 v) { return new Vector4(v.z, v.w, v.z, v.w ); }
		public static Vector4 zwwo(this Vector4 v) { return new Vector4(v.z, v.w, v.w, 0 ); }
		public static Vector4 zwwx(this Vector4 v) { return new Vector4(v.z, v.w, v.w, v.x ); }
		public static Vector4 zwwy(this Vector4 v) { return new Vector4(v.z, v.w, v.w, v.y ); }
		public static Vector4 zwwz(this Vector4 v) { return new Vector4(v.z, v.w, v.w, v.z ); }
		public static Vector4 zwww(this Vector4 v) { return new Vector4(v.z, v.w, v.w, v.w ); }
		public static Vector4 wooo(this Vector4 v) { return new Vector4(v.w, 0, 0, 0 ); }
		public static Vector4 woox(this Vector4 v) { return new Vector4(v.w, 0, 0, v.x ); }
		public static Vector4 wooy(this Vector4 v) { return new Vector4(v.w, 0, 0, v.y ); }
		public static Vector4 wooz(this Vector4 v) { return new Vector4(v.w, 0, 0, v.z ); }
		public static Vector4 woow(this Vector4 v) { return new Vector4(v.w, 0, 0, v.w ); }
		public static Vector4 woxo(this Vector4 v) { return new Vector4(v.w, 0, v.x, 0 ); }
		public static Vector4 woxx(this Vector4 v) { return new Vector4(v.w, 0, v.x, v.x ); }
		public static Vector4 woxy(this Vector4 v) { return new Vector4(v.w, 0, v.x, v.y ); }
		public static Vector4 woxz(this Vector4 v) { return new Vector4(v.w, 0, v.x, v.z ); }
		public static Vector4 woxw(this Vector4 v) { return new Vector4(v.w, 0, v.x, v.w ); }
		public static Vector4 woyo(this Vector4 v) { return new Vector4(v.w, 0, v.y, 0 ); }
		public static Vector4 woyx(this Vector4 v) { return new Vector4(v.w, 0, v.y, v.x ); }
		public static Vector4 woyy(this Vector4 v) { return new Vector4(v.w, 0, v.y, v.y ); }
		public static Vector4 woyz(this Vector4 v) { return new Vector4(v.w, 0, v.y, v.z ); }
		public static Vector4 woyw(this Vector4 v) { return new Vector4(v.w, 0, v.y, v.w ); }
		public static Vector4 wozo(this Vector4 v) { return new Vector4(v.w, 0, v.z, 0 ); }
		public static Vector4 wozx(this Vector4 v) { return new Vector4(v.w, 0, v.z, v.x ); }
		public static Vector4 wozy(this Vector4 v) { return new Vector4(v.w, 0, v.z, v.y ); }
		public static Vector4 wozz(this Vector4 v) { return new Vector4(v.w, 0, v.z, v.z ); }
		public static Vector4 wozw(this Vector4 v) { return new Vector4(v.w, 0, v.z, v.w ); }
		public static Vector4 wowo(this Vector4 v) { return new Vector4(v.w, 0, v.w, 0 ); }
		public static Vector4 wowx(this Vector4 v) { return new Vector4(v.w, 0, v.w, v.x ); }
		public static Vector4 wowy(this Vector4 v) { return new Vector4(v.w, 0, v.w, v.y ); }
		public static Vector4 wowz(this Vector4 v) { return new Vector4(v.w, 0, v.w, v.z ); }
		public static Vector4 woww(this Vector4 v) { return new Vector4(v.w, 0, v.w, v.w ); }
		public static Vector4 wxoo(this Vector4 v) { return new Vector4(v.w, v.x, 0, 0 ); }
		public static Vector4 wxox(this Vector4 v) { return new Vector4(v.w, v.x, 0, v.x ); }
		public static Vector4 wxoy(this Vector4 v) { return new Vector4(v.w, v.x, 0, v.y ); }
		public static Vector4 wxoz(this Vector4 v) { return new Vector4(v.w, v.x, 0, v.z ); }
		public static Vector4 wxow(this Vector4 v) { return new Vector4(v.w, v.x, 0, v.w ); }
		public static Vector4 wxxo(this Vector4 v) { return new Vector4(v.w, v.x, v.x, 0 ); }
		public static Vector4 wxxx(this Vector4 v) { return new Vector4(v.w, v.x, v.x, v.x ); }
		public static Vector4 wxxy(this Vector4 v) { return new Vector4(v.w, v.x, v.x, v.y ); }
		public static Vector4 wxxz(this Vector4 v) { return new Vector4(v.w, v.x, v.x, v.z ); }
		public static Vector4 wxxw(this Vector4 v) { return new Vector4(v.w, v.x, v.x, v.w ); }
		public static Vector4 wxyo(this Vector4 v) { return new Vector4(v.w, v.x, v.y, 0 ); }
		public static Vector4 wxyx(this Vector4 v) { return new Vector4(v.w, v.x, v.y, v.x ); }
		public static Vector4 wxyy(this Vector4 v) { return new Vector4(v.w, v.x, v.y, v.y ); }
		public static Vector4 wxyz(this Vector4 v) { return new Vector4(v.w, v.x, v.y, v.z ); }
		public static Vector4 wxyw(this Vector4 v) { return new Vector4(v.w, v.x, v.y, v.w ); }
		public static Vector4 wxzo(this Vector4 v) { return new Vector4(v.w, v.x, v.z, 0 ); }
		public static Vector4 wxzx(this Vector4 v) { return new Vector4(v.w, v.x, v.z, v.x ); }
		public static Vector4 wxzy(this Vector4 v) { return new Vector4(v.w, v.x, v.z, v.y ); }
		public static Vector4 wxzz(this Vector4 v) { return new Vector4(v.w, v.x, v.z, v.z ); }
		public static Vector4 wxzw(this Vector4 v) { return new Vector4(v.w, v.x, v.z, v.w ); }
		public static Vector4 wxwo(this Vector4 v) { return new Vector4(v.w, v.x, v.w, 0 ); }
		public static Vector4 wxwx(this Vector4 v) { return new Vector4(v.w, v.x, v.w, v.x ); }
		public static Vector4 wxwy(this Vector4 v) { return new Vector4(v.w, v.x, v.w, v.y ); }
		public static Vector4 wxwz(this Vector4 v) { return new Vector4(v.w, v.x, v.w, v.z ); }
		public static Vector4 wxww(this Vector4 v) { return new Vector4(v.w, v.x, v.w, v.w ); }
		public static Vector4 wyoo(this Vector4 v) { return new Vector4(v.w, v.y, 0, 0 ); }
		public static Vector4 wyox(this Vector4 v) { return new Vector4(v.w, v.y, 0, v.x ); }
		public static Vector4 wyoy(this Vector4 v) { return new Vector4(v.w, v.y, 0, v.y ); }
		public static Vector4 wyoz(this Vector4 v) { return new Vector4(v.w, v.y, 0, v.z ); }
		public static Vector4 wyow(this Vector4 v) { return new Vector4(v.w, v.y, 0, v.w ); }
		public static Vector4 wyxo(this Vector4 v) { return new Vector4(v.w, v.y, v.x, 0 ); }
		public static Vector4 wyxx(this Vector4 v) { return new Vector4(v.w, v.y, v.x, v.x ); }
		public static Vector4 wyxy(this Vector4 v) { return new Vector4(v.w, v.y, v.x, v.y ); }
		public static Vector4 wyxz(this Vector4 v) { return new Vector4(v.w, v.y, v.x, v.z ); }
		public static Vector4 wyxw(this Vector4 v) { return new Vector4(v.w, v.y, v.x, v.w ); }
		public static Vector4 wyyo(this Vector4 v) { return new Vector4(v.w, v.y, v.y, 0 ); }
		public static Vector4 wyyx(this Vector4 v) { return new Vector4(v.w, v.y, v.y, v.x ); }
		public static Vector4 wyyy(this Vector4 v) { return new Vector4(v.w, v.y, v.y, v.y ); }
		public static Vector4 wyyz(this Vector4 v) { return new Vector4(v.w, v.y, v.y, v.z ); }
		public static Vector4 wyyw(this Vector4 v) { return new Vector4(v.w, v.y, v.y, v.w ); }
		public static Vector4 wyzo(this Vector4 v) { return new Vector4(v.w, v.y, v.z, 0 ); }
		public static Vector4 wyzx(this Vector4 v) { return new Vector4(v.w, v.y, v.z, v.x ); }
		public static Vector4 wyzy(this Vector4 v) { return new Vector4(v.w, v.y, v.z, v.y ); }
		public static Vector4 wyzz(this Vector4 v) { return new Vector4(v.w, v.y, v.z, v.z ); }
		public static Vector4 wyzw(this Vector4 v) { return new Vector4(v.w, v.y, v.z, v.w ); }
		public static Vector4 wywo(this Vector4 v) { return new Vector4(v.w, v.y, v.w, 0 ); }
		public static Vector4 wywx(this Vector4 v) { return new Vector4(v.w, v.y, v.w, v.x ); }
		public static Vector4 wywy(this Vector4 v) { return new Vector4(v.w, v.y, v.w, v.y ); }
		public static Vector4 wywz(this Vector4 v) { return new Vector4(v.w, v.y, v.w, v.z ); }
		public static Vector4 wyww(this Vector4 v) { return new Vector4(v.w, v.y, v.w, v.w ); }
		public static Vector4 wzoo(this Vector4 v) { return new Vector4(v.w, v.z, 0, 0 ); }
		public static Vector4 wzox(this Vector4 v) { return new Vector4(v.w, v.z, 0, v.x ); }
		public static Vector4 wzoy(this Vector4 v) { return new Vector4(v.w, v.z, 0, v.y ); }
		public static Vector4 wzoz(this Vector4 v) { return new Vector4(v.w, v.z, 0, v.z ); }
		public static Vector4 wzow(this Vector4 v) { return new Vector4(v.w, v.z, 0, v.w ); }
		public static Vector4 wzxo(this Vector4 v) { return new Vector4(v.w, v.z, v.x, 0 ); }
		public static Vector4 wzxx(this Vector4 v) { return new Vector4(v.w, v.z, v.x, v.x ); }
		public static Vector4 wzxy(this Vector4 v) { return new Vector4(v.w, v.z, v.x, v.y ); }
		public static Vector4 wzxz(this Vector4 v) { return new Vector4(v.w, v.z, v.x, v.z ); }
		public static Vector4 wzxw(this Vector4 v) { return new Vector4(v.w, v.z, v.x, v.w ); }
		public static Vector4 wzyo(this Vector4 v) { return new Vector4(v.w, v.z, v.y, 0 ); }
		public static Vector4 wzyx(this Vector4 v) { return new Vector4(v.w, v.z, v.y, v.x ); }
		public static Vector4 wzyy(this Vector4 v) { return new Vector4(v.w, v.z, v.y, v.y ); }
		public static Vector4 wzyz(this Vector4 v) { return new Vector4(v.w, v.z, v.y, v.z ); }
		public static Vector4 wzyw(this Vector4 v) { return new Vector4(v.w, v.z, v.y, v.w ); }
		public static Vector4 wzzo(this Vector4 v) { return new Vector4(v.w, v.z, v.z, 0 ); }
		public static Vector4 wzzx(this Vector4 v) { return new Vector4(v.w, v.z, v.z, v.x ); }
		public static Vector4 wzzy(this Vector4 v) { return new Vector4(v.w, v.z, v.z, v.y ); }
		public static Vector4 wzzz(this Vector4 v) { return new Vector4(v.w, v.z, v.z, v.z ); }
		public static Vector4 wzzw(this Vector4 v) { return new Vector4(v.w, v.z, v.z, v.w ); }
		public static Vector4 wzwo(this Vector4 v) { return new Vector4(v.w, v.z, v.w, 0 ); }
		public static Vector4 wzwx(this Vector4 v) { return new Vector4(v.w, v.z, v.w, v.x ); }
		public static Vector4 wzwy(this Vector4 v) { return new Vector4(v.w, v.z, v.w, v.y ); }
		public static Vector4 wzwz(this Vector4 v) { return new Vector4(v.w, v.z, v.w, v.z ); }
		public static Vector4 wzww(this Vector4 v) { return new Vector4(v.w, v.z, v.w, v.w ); }
		public static Vector4 wwoo(this Vector4 v) { return new Vector4(v.w, v.w, 0, 0 ); }
		public static Vector4 wwox(this Vector4 v) { return new Vector4(v.w, v.w, 0, v.x ); }
		public static Vector4 wwoy(this Vector4 v) { return new Vector4(v.w, v.w, 0, v.y ); }
		public static Vector4 wwoz(this Vector4 v) { return new Vector4(v.w, v.w, 0, v.z ); }
		public static Vector4 wwow(this Vector4 v) { return new Vector4(v.w, v.w, 0, v.w ); }
		public static Vector4 wwxo(this Vector4 v) { return new Vector4(v.w, v.w, v.x, 0 ); }
		public static Vector4 wwxx(this Vector4 v) { return new Vector4(v.w, v.w, v.x, v.x ); }
		public static Vector4 wwxy(this Vector4 v) { return new Vector4(v.w, v.w, v.x, v.y ); }
		public static Vector4 wwxz(this Vector4 v) { return new Vector4(v.w, v.w, v.x, v.z ); }
		public static Vector4 wwxw(this Vector4 v) { return new Vector4(v.w, v.w, v.x, v.w ); }
		public static Vector4 wwyo(this Vector4 v) { return new Vector4(v.w, v.w, v.y, 0 ); }
		public static Vector4 wwyx(this Vector4 v) { return new Vector4(v.w, v.w, v.y, v.x ); }
		public static Vector4 wwyy(this Vector4 v) { return new Vector4(v.w, v.w, v.y, v.y ); }
		public static Vector4 wwyz(this Vector4 v) { return new Vector4(v.w, v.w, v.y, v.z ); }
		public static Vector4 wwyw(this Vector4 v) { return new Vector4(v.w, v.w, v.y, v.w ); }
		public static Vector4 wwzo(this Vector4 v) { return new Vector4(v.w, v.w, v.z, 0 ); }
		public static Vector4 wwzx(this Vector4 v) { return new Vector4(v.w, v.w, v.z, v.x ); }
		public static Vector4 wwzy(this Vector4 v) { return new Vector4(v.w, v.w, v.z, v.y ); }
		public static Vector4 wwzz(this Vector4 v) { return new Vector4(v.w, v.w, v.z, v.z ); }
		public static Vector4 wwzw(this Vector4 v) { return new Vector4(v.w, v.w, v.z, v.w ); }
		public static Vector4 wwwo(this Vector4 v) { return new Vector4(v.w, v.w, v.w, 0 ); }
		public static Vector4 wwwx(this Vector4 v) { return new Vector4(v.w, v.w, v.w, v.x ); }
		public static Vector4 wwwy(this Vector4 v) { return new Vector4(v.w, v.w, v.w, v.y ); }
		public static Vector4 wwwz(this Vector4 v) { return new Vector4(v.w, v.w, v.w, v.z ); }
		public static Vector4 wwww(this Vector4 v) { return new Vector4(v.w, v.w, v.w, v.w ); }
	}
}
