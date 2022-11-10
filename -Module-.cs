using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

// Token: 0x02000001 RID: 1
internal class <Module>
{
	// Token: 0x06000002 RID: 2
	[DllImport("kernel32.dll")]
	internal unsafe static extern bool VirtualProtect(byte* pByte_0, int int_0, uint uint_0, ref uint uint_1);

	// Token: 0x06000003 RID: 3 RVA: 0x00002C60 File Offset: 0x00000E60
	internal static byte[] smethod_0(byte[] byte_1)
	{
		MemoryStream memoryStream = new MemoryStream(byte_1);
		<Module>.Class1 @class = new <Module>.Class1();
		byte[] buffer = new byte[5];
		memoryStream.Read(buffer, 0, 5);
		@class.method_5(buffer);
		long num = 0L;
		for (int i = 0; i < 8; i++)
		{
			int num2 = memoryStream.ReadByte();
			num |= (long)((long)((ulong)((byte)num2)) << 8 * i);
		}
		byte[] array = new byte[(int)num];
		MemoryStream stream_ = new MemoryStream(array, true);
		long long_ = memoryStream.Length - 13L;
		@class.method_4(memoryStream, stream_, long_, num);
		return array;
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002CF4 File Offset: 0x00000EF4
	internal static Assembly smethod_1(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		if (Array.IndexOf<string>(<Module>.assembly_0.GetManifestResourceNames(), resolveEventArgs_0.Name) != -1)
		{
			return <Module>.assembly_0;
		}
		return null;
	}

	// Token: 0x06000005 RID: 5
	[DllImport("kernel32.dll", EntryPoint = "VirtualProtect")]
	internal static extern bool VirtualProtect_1(IntPtr intptr_0, uint uint_0, uint uint_1, ref uint uint_2);

	// Token: 0x06000006 RID: 6
	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	internal static extern bool CheckRemoteDebuggerPresent(IntPtr intptr_0, ref bool bool_0);

	// Token: 0x06000007 RID: 7 RVA: 0x00002D20 File Offset: 0x00000F20
	internal unsafe static void smethod_2()
	{
		Module module = typeof(<Module>).Module;
		string fullyQualifiedName = module.FullyQualifiedName;
		bool flag = fullyQualifiedName.Length > 0 && fullyQualifiedName[0] == '<';
		byte* ptr = (byte*)((void*)Marshal.GetHINSTANCE(module));
		byte* ptr2 = ptr + *(uint*)(ptr + 60);
		ushort num = *(ushort*)(ptr2 + 6);
		ushort num2 = *(ushort*)(ptr2 + 20);
		bool flag2 = false;
		uint* ptr3 = null;
		uint num3 = 0U;
		uint* ptr4 = (uint*)(ptr2 + 24 + num2);
		uint num4 = 3151380935U;
		uint num5 = 116898578U;
		uint num6 = 3395909508U;
		uint num7 = 677066275U;
		<Module>.CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref flag2);
		if (flag2)
		{
			Environment.FailFast(null);
		}
		for (int i = 0; i < (int)num; i++)
		{
			uint num8 = *(ptr4++) * *(ptr4++);
			if (num8 != 3480670374U)
			{
				if (num8 != 0U)
				{
					uint* ptr5 = (uint*)(ptr + (UIntPtr)(flag ? ptr4[3] : ptr4[1]) / 4);
					uint num9 = ptr4[2] >> 2;
					for (uint num10 = 0U; num10 < num9; num10 += 1U)
					{
						uint num11 = (num4 ^ *(ptr5++)) + num5 + num6 * num7;
						num4 = num5;
						num5 = num7;
						num7 = num11;
					}
				}
			}
			else
			{
				ptr3 = (uint*)(ptr + (UIntPtr)(flag ? ptr4[3] : ptr4[1]) / 4);
				<Module>.CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref flag2);
				if (flag2)
				{
					Environment.FailFast(null);
				}
				num3 = (flag ? ptr4[2] : (*ptr4)) >> 2;
			}
			ptr4 += 8;
		}
		uint[] array = new uint[16];
		uint[] array2 = new uint[16];
		for (int j = 0; j < 16; j++)
		{
			array[j] = num7;
			array2[j] = num5;
			num4 = (num5 >> 5 | num5 << 27);
			num5 = (num6 >> 3 | num6 << 29);
			<Module>.CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref flag2);
			if (flag2)
			{
				Environment.FailFast(null);
			}
			num6 = (num7 >> 7 | num7 << 25);
			num7 = (num4 >> 11 | num4 << 21);
		}
		array[0] = (array[0] ^ array2[0]);
		array[1] = array[1] * array2[1];
		array[2] = array[2] + array2[2];
		array[3] = (array[3] ^ array2[3]);
		array[4] = array[4] * array2[4];
		array[5] = array[5] + array2[5];
		array[6] = (array[6] ^ array2[6]);
		array[7] = array[7] * array2[7];
		array[8] = array[8] + array2[8];
		array[9] = (array[9] ^ array2[9]);
		array[10] = array[10] * array2[10];
		array[11] = array[11] + array2[11];
		array[12] = (array[12] ^ array2[12]);
		array[13] = array[13] * array2[13];
		array[14] = array[14] + array2[14];
		array[15] = (array[15] ^ array2[15]);
		uint num12 = 64U;
		<Module>.VirtualProtect_1((IntPtr)((void*)ptr3), num3 << 2, 64U, ref num12);
		if (num12 != 64U)
		{
			uint num13 = 0U;
			for (uint num14 = 0U; num14 < num3; num14 += 1U)
			{
				*ptr3 ^= array[(int)(num13 & 15U)];
				array[(int)(num13 & 15U)] = (array[(int)(num13 & 15U)] ^ *(ptr3++)) + 1035675673U;
				<Module>.CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref flag2);
				if (flag2)
				{
					Environment.FailFast(null);
				}
				num13 += 1U;
			}
			return;
		}
	}

	// Token: 0x04000001 RID: 1
	internal static byte[] byte_0;

	// Token: 0x04000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
	internal static <Module>.Struct4 struct4_0;

	// Token: 0x04000003 RID: 3
	internal static Assembly assembly_0;

	// Token: 0x04000004 RID: 4 RVA: 0x00002A90 File Offset: 0x00000C90
	internal static <Module>.Struct5 struct5_0;

	// Token: 0x02000002 RID: 2
	internal struct Struct0
	{
		// Token: 0x06000008 RID: 8 RVA: 0x0000308C File Offset: 0x0000128C
		internal void method_0()
		{
			this.uint_0 = 1024U;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000030A4 File Offset: 0x000012A4
		internal uint method_1(<Module>.Class0 class0_0)
		{
			uint num = (class0_0.uint_1 >> 11) * this.uint_0;
			if (class0_0.uint_0 < num)
			{
				class0_0.uint_1 = num;
				this.uint_0 += 2048U - this.uint_0 >> 5;
				if (class0_0.uint_1 < 16777216U)
				{
					class0_0.uint_0 = (class0_0.uint_0 << 8 | (uint)((byte)class0_0.stream_0.ReadByte()));
					class0_0.uint_1 <<= 8;
				}
				return 0U;
			}
			class0_0.uint_1 -= num;
			class0_0.uint_0 -= num;
			this.uint_0 -= this.uint_0 >> 5;
			if (class0_0.uint_1 < 16777216U)
			{
				class0_0.uint_0 = (class0_0.uint_0 << 8 | (uint)((byte)class0_0.stream_0.ReadByte()));
				class0_0.uint_1 <<= 8;
			}
			return 1U;
		}

		// Token: 0x04000005 RID: 5
		internal uint uint_0;
	}

	// Token: 0x02000003 RID: 3
	internal struct Struct1
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00003190 File Offset: 0x00001390
		internal Struct1(int int_1)
		{
			this.int_0 = int_1;
			this.struct0_0 = new <Module>.Struct0[1 << int_1];
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000031B8 File Offset: 0x000013B8
		internal void method_0()
		{
			uint num = 1U;
			while ((ulong)num < (ulong)(1L << (this.int_0 & 31)))
			{
				this.struct0_0[(int)num].method_0();
				num += 1U;
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000031F0 File Offset: 0x000013F0
		internal uint method_1(<Module>.Class0 class0_0)
		{
			uint num = 1U;
			for (int i = this.int_0; i > 0; i--)
			{
				num = (num << 1) + this.struct0_0[(int)num].method_1(class0_0);
			}
			return num - (1U << this.int_0);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00003234 File Offset: 0x00001434
		internal uint method_2(<Module>.Class0 class0_0)
		{
			uint num = 1U;
			uint num2 = 0U;
			for (int i = 0; i < this.int_0; i++)
			{
				uint num3 = this.struct0_0[(int)num].method_1(class0_0);
				num <<= 1;
				num += num3;
				num2 |= num3 << i;
			}
			return num2;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000327C File Offset: 0x0000147C
		internal static uint smethod_0(<Module>.Struct0[] struct0_1, uint uint_0, <Module>.Class0 class0_0, int int_1)
		{
			uint num = 1U;
			uint num2 = 0U;
			for (int i = 0; i < int_1; i++)
			{
				uint num3 = struct0_1[(int)(uint_0 + num)].method_1(class0_0);
				num <<= 1;
				num += num3;
				num2 |= num3 << i;
			}
			return num2;
		}

		// Token: 0x04000006 RID: 6
		internal readonly <Module>.Struct0[] struct0_0;

		// Token: 0x04000007 RID: 7
		internal readonly int int_0;
	}

	// Token: 0x02000004 RID: 4
	internal class Class0
	{
		// Token: 0x0600000F RID: 15 RVA: 0x000032BC File Offset: 0x000014BC
		internal void method_0(Stream stream_1)
		{
			this.stream_0 = stream_1;
			this.uint_0 = 0U;
			this.uint_1 = uint.MaxValue;
			for (int i = 0; i < 5; i++)
			{
				this.uint_0 = (this.uint_0 << 8 | (uint)((byte)this.stream_0.ReadByte()));
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00003308 File Offset: 0x00001508
		internal void method_1()
		{
			this.stream_0 = null;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000331C File Offset: 0x0000151C
		internal void method_2()
		{
			while (this.uint_1 < 16777216U)
			{
				this.uint_0 = (this.uint_0 << 8 | (uint)((byte)this.stream_0.ReadByte()));
				this.uint_1 <<= 8;
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00003364 File Offset: 0x00001564
		internal uint method_3(int int_0)
		{
			uint num = this.uint_1;
			uint num2 = this.uint_0;
			uint num3 = 0U;
			for (int i = int_0; i > 0; i--)
			{
				num >>= 1;
				uint num4 = num2 - num >> 31;
				num2 -= (num & num4 - 1U);
				num3 = (num3 << 1 | 1U - num4);
				if (num < 16777216U)
				{
					num2 = (num2 << 8 | (uint)((byte)this.stream_0.ReadByte()));
					num <<= 8;
				}
			}
			this.uint_1 = num;
			this.uint_0 = num2;
			return num3;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000033D8 File Offset: 0x000015D8
		internal Class0()
		{
		}

		// Token: 0x04000008 RID: 8
		internal uint uint_0;

		// Token: 0x04000009 RID: 9
		internal uint uint_1;

		// Token: 0x0400000A RID: 10
		internal Stream stream_0;
	}

	// Token: 0x02000005 RID: 5
	internal class Class1
	{
		// Token: 0x06000014 RID: 20 RVA: 0x000033EC File Offset: 0x000015EC
		internal Class1()
		{
			this.uint_0 = uint.MaxValue;
			int num = 0;
			while ((long)num < 4L)
			{
				this.struct1_0[num] = new <Module>.Struct1(6);
				num++;
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000034E0 File Offset: 0x000016E0
		internal void method_0(uint uint_3)
		{
			if (this.uint_0 != uint_3)
			{
				this.uint_0 = uint_3;
				this.uint_1 = Math.Max(this.uint_0, 1U);
				uint uint_4 = Math.Max(this.uint_1, 4096U);
				this.class4_0.method_0(uint_4);
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000352C File Offset: 0x0000172C
		internal void method_1(int int_0, int int_1)
		{
			this.class3_0.method_0(int_0, int_1);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00003548 File Offset: 0x00001748
		internal void method_2(int int_0)
		{
			uint num = 1U << int_0;
			this.class2_0.method_0(num);
			this.class2_1.method_0(num);
			this.uint_2 = num - 1U;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003580 File Offset: 0x00001780
		internal void method_3(Stream stream_0, Stream stream_1)
		{
			this.class0_0.method_0(stream_0);
			this.class4_0.method_1(stream_1, this.bool_0);
			for (uint num = 0U; num < 12U; num += 1U)
			{
				for (uint num2 = 0U; num2 <= this.uint_2; num2 += 1U)
				{
					uint num3 = (num << 4) + num2;
					this.struct0_0[(int)num3].method_0();
					this.struct0_1[(int)num3].method_0();
				}
				this.struct0_2[(int)num].method_0();
				this.struct0_3[(int)num].method_0();
				this.struct0_4[(int)num].method_0();
				this.struct0_5[(int)num].method_0();
			}
			this.class3_0.method_1();
			for (uint num = 0U; num < 4U; num += 1U)
			{
				this.struct1_0[(int)num].method_0();
			}
			for (uint num = 0U; num < 114U; num += 1U)
			{
				this.struct0_6[(int)num].method_0();
			}
			this.class2_0.method_1();
			this.class2_1.method_1();
			this.struct1_1.method_0();
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000036A4 File Offset: 0x000018A4
		internal void method_4(Stream stream_0, Stream stream_1, long long_0, long long_1)
		{
			this.method_3(stream_0, stream_1);
			<Module>.Struct3 @struct = default(<Module>.Struct3);
			@struct.method_0();
			uint num = 0U;
			uint num2 = 0U;
			uint num3 = 0U;
			uint num4 = 0U;
			ulong num5 = 0UL;
			if (0L < long_1)
			{
				this.struct0_0[(int)((int)@struct.uint_0 << 4)].method_1(this.class0_0);
				@struct.method_1();
				byte byte_ = this.class3_0.method_3(this.class0_0, 0U, 0);
				this.class4_0.method_5(byte_);
				num5 += 1UL;
			}
			while (num5 < (ulong)long_1)
			{
				uint num6 = (uint)num5 & this.uint_2;
				if (this.struct0_0[(int)((@struct.uint_0 << 4) + num6)].method_1(this.class0_0) == 0U)
				{
					byte byte_2 = this.class4_0.method_6(0U);
					byte byte_3;
					if (!@struct.method_5())
					{
						byte_3 = this.class3_0.method_4(this.class0_0, (uint)num5, byte_2, this.class4_0.method_6(num));
					}
					else
					{
						byte_3 = this.class3_0.method_3(this.class0_0, (uint)num5, byte_2);
					}
					this.class4_0.method_5(byte_3);
					@struct.method_1();
					num5 += 1UL;
				}
				else
				{
					uint num7;
					if (this.struct0_2[(int)@struct.uint_0].method_1(this.class0_0) != 1U)
					{
						num4 = num3;
						num3 = num2;
						num2 = num;
						num7 = 2U + this.class2_0.method_2(this.class0_0, num6);
						@struct.method_2();
						uint num8 = this.struct1_0[(int)<Module>.Class1.smethod_0(num7)].method_1(this.class0_0);
						if (num8 < 4U)
						{
							num = num8;
						}
						else
						{
							int num9 = (int)((num8 >> 1) - 1U);
							num = (2U | (num8 & 1U)) << num9;
							if (num8 < 14U)
							{
								num += <Module>.Struct1.smethod_0(this.struct0_6, num - num8 - 1U, this.class0_0, num9);
							}
							else
							{
								num += this.class0_0.method_3(num9 - 4) << 4;
								num += this.struct1_1.method_2(this.class0_0);
							}
						}
					}
					else
					{
						if (this.struct0_3[(int)@struct.uint_0].method_1(this.class0_0) != 0U)
						{
							uint num10;
							if (this.struct0_4[(int)@struct.uint_0].method_1(this.class0_0) != 0U)
							{
								if (this.struct0_5[(int)@struct.uint_0].method_1(this.class0_0) != 0U)
								{
									num10 = num4;
									num4 = num3;
								}
								else
								{
									num10 = num3;
								}
								num3 = num2;
							}
							else
							{
								num10 = num2;
							}
							num2 = num;
							num = num10;
						}
						else if (this.struct0_1[(int)((@struct.uint_0 << 4) + num6)].method_1(this.class0_0) == 0U)
						{
							@struct.method_4();
							this.class4_0.method_5(this.class4_0.method_6(num));
							num5 += 1UL;
							continue;
						}
						num7 = this.class2_1.method_2(this.class0_0, num6) + 2U;
						@struct.method_3();
					}
					if (((ulong)num >= num5 || num >= this.uint_1) && num == 4294967295U)
					{
						break;
					}
					this.class4_0.method_4(num, num7);
					num5 += (ulong)num7;
				}
			}
			this.class4_0.method_3();
			this.class4_0.method_2();
			this.class0_0.method_1();
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00003A08 File Offset: 0x00001C08
		internal void method_5(byte[] byte_0)
		{
			int int_ = (int)(byte_0[0] % 9);
			byte b = byte_0[0] / 9;
			int int_2 = (int)(b % 5);
			int int_3 = (int)(b / 5);
			uint num = 0U;
			for (int i = 0; i < 4; i++)
			{
				num += (uint)((uint)byte_0[1 + i] << i * 8);
			}
			this.method_0(num);
			this.method_1(int_2, int_);
			this.method_2(int_3);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00003A64 File Offset: 0x00001C64
		internal static uint smethod_0(uint uint_3)
		{
			uint_3 -= 2U;
			if (uint_3 < 4U)
			{
				return uint_3;
			}
			return 3U;
		}

		// Token: 0x0400000B RID: 11
		internal readonly <Module>.Struct0[] struct0_0 = new <Module>.Struct0[192];

		// Token: 0x0400000C RID: 12
		internal readonly <Module>.Struct0[] struct0_1 = new <Module>.Struct0[192];

		// Token: 0x0400000D RID: 13
		internal readonly <Module>.Struct0[] struct0_2 = new <Module>.Struct0[12];

		// Token: 0x0400000E RID: 14
		internal readonly <Module>.Struct0[] struct0_3 = new <Module>.Struct0[12];

		// Token: 0x0400000F RID: 15
		internal readonly <Module>.Struct0[] struct0_4 = new <Module>.Struct0[12];

		// Token: 0x04000010 RID: 16
		internal readonly <Module>.Struct0[] struct0_5 = new <Module>.Struct0[12];

		// Token: 0x04000011 RID: 17
		internal readonly <Module>.Class1.Class2 class2_0 = new <Module>.Class1.Class2();

		// Token: 0x04000012 RID: 18
		internal readonly <Module>.Class1.Class3 class3_0 = new <Module>.Class1.Class3();

		// Token: 0x04000013 RID: 19
		internal readonly <Module>.Class4 class4_0 = new <Module>.Class4();

		// Token: 0x04000014 RID: 20
		internal readonly <Module>.Struct0[] struct0_6 = new <Module>.Struct0[114];

		// Token: 0x04000015 RID: 21
		internal readonly <Module>.Struct1[] struct1_0 = new <Module>.Struct1[4];

		// Token: 0x04000016 RID: 22
		internal readonly <Module>.Class0 class0_0 = new <Module>.Class0();

		// Token: 0x04000017 RID: 23
		internal readonly <Module>.Class1.Class2 class2_1 = new <Module>.Class1.Class2();

		// Token: 0x04000018 RID: 24
		internal bool bool_0;

		// Token: 0x04000019 RID: 25
		internal uint uint_0;

		// Token: 0x0400001A RID: 26
		internal uint uint_1;

		// Token: 0x0400001B RID: 27
		internal <Module>.Struct1 struct1_1 = new <Module>.Struct1(4);

		// Token: 0x0400001C RID: 28
		internal uint uint_2;

		// Token: 0x02000006 RID: 6
		internal class Class2
		{
			// Token: 0x0600001C RID: 28 RVA: 0x00003A80 File Offset: 0x00001C80
			internal void method_0(uint uint_1)
			{
				for (uint num = this.uint_0; num < uint_1; num += 1U)
				{
					this.struct1_0[(int)num] = new <Module>.Struct1(3);
					this.struct1_1[(int)num] = new <Module>.Struct1(3);
				}
				this.uint_0 = uint_1;
			}

			// Token: 0x0600001D RID: 29 RVA: 0x00003ACC File Offset: 0x00001CCC
			internal void method_1()
			{
				this.struct0_0.method_0();
				for (uint num = 0U; num < this.uint_0; num += 1U)
				{
					this.struct1_0[(int)num].method_0();
					this.struct1_1[(int)num].method_0();
				}
				this.struct0_1.method_0();
				this.struct1_2.method_0();
			}

			// Token: 0x0600001E RID: 30 RVA: 0x00003B30 File Offset: 0x00001D30
			internal uint method_2(<Module>.Class0 class0_0, uint uint_1)
			{
				if (this.struct0_0.method_1(class0_0) == 0U)
				{
					return this.struct1_0[(int)uint_1].method_1(class0_0);
				}
				uint num = 8U;
				if (this.struct0_1.method_1(class0_0) == 0U)
				{
					num += this.struct1_1[(int)uint_1].method_1(class0_0);
				}
				else
				{
					num += 8U;
					num += this.struct1_2.method_1(class0_0);
				}
				return num;
			}

			// Token: 0x0600001F RID: 31 RVA: 0x00003B9C File Offset: 0x00001D9C
			internal Class2()
			{
			}

			// Token: 0x0400001D RID: 29
			internal readonly <Module>.Struct1[] struct1_0 = new <Module>.Struct1[16];

			// Token: 0x0400001E RID: 30
			internal readonly <Module>.Struct1[] struct1_1 = new <Module>.Struct1[16];

			// Token: 0x0400001F RID: 31
			internal <Module>.Struct0 struct0_0;

			// Token: 0x04000020 RID: 32
			internal <Module>.Struct0 struct0_1;

			// Token: 0x04000021 RID: 33
			internal <Module>.Struct1 struct1_2 = new <Module>.Struct1(8);

			// Token: 0x04000022 RID: 34
			internal uint uint_0;
		}

		// Token: 0x02000007 RID: 7
		internal class Class3
		{
			// Token: 0x06000020 RID: 32 RVA: 0x00003BD8 File Offset: 0x00001DD8
			internal void method_0(int int_2, int int_3)
			{
				if (this.struct2_0 != null)
				{
					if (this.int_1 == int_3)
					{
						if (this.int_0 == int_2)
						{
							return;
						}
					}
				}
				this.int_0 = int_2;
				this.uint_0 = (1U << int_2) - 1U;
				this.int_1 = int_3;
				uint num = 1U << this.int_1 + this.int_0;
				this.struct2_0 = new <Module>.Class1.Class3.Struct2[num];
				for (uint num2 = 0U; num2 < num; num2 += 1U)
				{
					this.struct2_0[(int)num2].method_0();
				}
			}

			// Token: 0x06000021 RID: 33 RVA: 0x00003C5C File Offset: 0x00001E5C
			internal void method_1()
			{
				uint num = 1U << this.int_1 + this.int_0;
				for (uint num2 = 0U; num2 < num; num2 += 1U)
				{
					this.struct2_0[(int)num2].method_1();
				}
			}

			// Token: 0x06000022 RID: 34 RVA: 0x00003C9C File Offset: 0x00001E9C
			internal uint method_2(uint uint_1, byte byte_0)
			{
				return ((uint_1 & this.uint_0) << this.int_1) + (uint)(byte_0 >> 8 - this.int_1);
			}

			// Token: 0x06000023 RID: 35 RVA: 0x00003CCC File Offset: 0x00001ECC
			internal byte method_3(<Module>.Class0 class0_0, uint uint_1, byte byte_0)
			{
				return this.struct2_0[(int)this.method_2(uint_1, byte_0)].method_2(class0_0);
			}

			// Token: 0x06000024 RID: 36 RVA: 0x00003CF4 File Offset: 0x00001EF4
			internal byte method_4(<Module>.Class0 class0_0, uint uint_1, byte byte_0, byte byte_1)
			{
				return this.struct2_0[(int)this.method_2(uint_1, byte_0)].method_3(class0_0, byte_1);
			}

			// Token: 0x06000025 RID: 37 RVA: 0x000033D8 File Offset: 0x000015D8
			internal Class3()
			{
			}

			// Token: 0x04000023 RID: 35
			internal <Module>.Class1.Class3.Struct2[] struct2_0;

			// Token: 0x04000024 RID: 36
			internal int int_0;

			// Token: 0x04000025 RID: 37
			internal int int_1;

			// Token: 0x04000026 RID: 38
			internal uint uint_0;

			// Token: 0x02000008 RID: 8
			internal struct Struct2
			{
				// Token: 0x06000026 RID: 38 RVA: 0x00003D1C File Offset: 0x00001F1C
				internal void method_0()
				{
					this.struct0_0 = new <Module>.Struct0[768];
				}

				// Token: 0x06000027 RID: 39 RVA: 0x00003D3C File Offset: 0x00001F3C
				internal void method_1()
				{
					for (int i = 0; i < 768; i++)
					{
						this.struct0_0[i].method_0();
					}
				}

				// Token: 0x06000028 RID: 40 RVA: 0x00003D6C File Offset: 0x00001F6C
				internal byte method_2(<Module>.Class0 class0_0)
				{
					uint num = 1U;
					do
					{
						num = (num << 1 | this.struct0_0[(int)num].method_1(class0_0));
					}
					while (num < 256U);
					return (byte)num;
				}

				// Token: 0x06000029 RID: 41 RVA: 0x00003DA0 File Offset: 0x00001FA0
				internal byte method_3(<Module>.Class0 class0_0, byte byte_0)
				{
					uint num = 1U;
					for (;;)
					{
						uint num2 = (uint)(byte_0 >> 7 & 1);
						byte_0 = (byte)(byte_0 << 1);
						uint num3 = this.struct0_0[(int)((1U + num2 << 8) + num)].method_1(class0_0);
						num = (num << 1 | num3);
						if (num2 != num3)
						{
							break;
						}
						if (num >= 256U)
						{
							goto IL_5C;
						}
					}
					while (num < 256U)
					{
						num = (num << 1 | this.struct0_0[(int)num].method_1(class0_0));
					}
					IL_5C:
					return (byte)num;
				}

				// Token: 0x04000027 RID: 39
				internal <Module>.Struct0[] struct0_0;
			}
		}
	}

	// Token: 0x02000009 RID: 9
	internal class Class4
	{
		// Token: 0x0600002A RID: 42 RVA: 0x00003E0C File Offset: 0x0000200C
		internal void method_0(uint uint_3)
		{
			if (this.uint_2 != uint_3)
			{
				this.byte_0 = new byte[uint_3];
			}
			this.uint_2 = uint_3;
			this.uint_0 = 0U;
			this.uint_1 = 0U;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003E44 File Offset: 0x00002044
		internal void method_1(Stream stream_1, bool bool_0)
		{
			this.method_2();
			this.stream_0 = stream_1;
			if (!bool_0)
			{
				this.uint_1 = 0U;
				this.uint_0 = 0U;
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003E70 File Offset: 0x00002070
		internal void method_2()
		{
			this.method_3();
			this.stream_0 = null;
			Buffer.BlockCopy(new byte[this.byte_0.Length], 0, this.byte_0, 0, this.byte_0.Length);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003EAC File Offset: 0x000020AC
		internal void method_3()
		{
			uint num = this.uint_0 - this.uint_1;
			if (num != 0U)
			{
				this.stream_0.Write(this.byte_0, (int)this.uint_1, (int)num);
				if (this.uint_0 >= this.uint_2)
				{
					this.uint_0 = 0U;
				}
				this.uint_1 = this.uint_0;
				return;
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003F04 File Offset: 0x00002104
		internal void method_4(uint uint_3, uint uint_4)
		{
			uint num = this.uint_0 - uint_3 - 1U;
			if (num >= this.uint_2)
			{
				num += this.uint_2;
			}
			while (uint_4 > 0U)
			{
				if (num >= this.uint_2)
				{
					num = 0U;
				}
				byte[] array = this.byte_0;
				uint num2 = this.uint_0;
				this.uint_0 = num2 + 1U;
				array[(int)num2] = this.byte_0[(int)num++];
				if (this.uint_0 >= this.uint_2)
				{
					this.method_3();
				}
				uint_4 -= 1U;
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003F7C File Offset: 0x0000217C
		internal void method_5(byte byte_1)
		{
			byte[] array = this.byte_0;
			uint num = this.uint_0;
			this.uint_0 = num + 1U;
			array[(int)num] = byte_1;
			if (this.uint_0 >= this.uint_2)
			{
				this.method_3();
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003FB8 File Offset: 0x000021B8
		internal byte method_6(uint uint_3)
		{
			uint num = this.uint_0 - uint_3 - 1U;
			if (num >= this.uint_2)
			{
				num += this.uint_2;
			}
			return this.byte_0[(int)num];
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000033D8 File Offset: 0x000015D8
		internal Class4()
		{
		}

		// Token: 0x04000028 RID: 40
		internal byte[] byte_0;

		// Token: 0x04000029 RID: 41
		internal uint uint_0;

		// Token: 0x0400002A RID: 42
		internal Stream stream_0;

		// Token: 0x0400002B RID: 43
		internal uint uint_1;

		// Token: 0x0400002C RID: 44
		internal uint uint_2;
	}

	// Token: 0x0200000A RID: 10
	internal struct Struct3
	{
		// Token: 0x06000032 RID: 50 RVA: 0x00003FEC File Offset: 0x000021EC
		internal void method_0()
		{
			this.uint_0 = 0U;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00004000 File Offset: 0x00002200
		internal void method_1()
		{
			if (this.uint_0 < 4U)
			{
				this.uint_0 = 0U;
				return;
			}
			if (this.uint_0 < 10U)
			{
				this.uint_0 -= 3U;
				return;
			}
			this.uint_0 -= 6U;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00004048 File Offset: 0x00002248
		internal void method_2()
		{
			this.uint_0 = ((this.uint_0 < 7U) ? 7U : 10U);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000406C File Offset: 0x0000226C
		internal void method_3()
		{
			this.uint_0 = ((this.uint_0 < 7U) ? 8U : 11U);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00004090 File Offset: 0x00002290
		internal void method_4()
		{
			this.uint_0 = ((this.uint_0 < 7U) ? 9U : 11U);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000040B4 File Offset: 0x000022B4
		internal bool method_5()
		{
			return this.uint_0 < 7U;
		}

		// Token: 0x0400002D RID: 45
		internal uint uint_0;
	}

	// Token: 0x0200000B RID: 11
	[StructLayout(LayoutKind.Explicit, Size = 2624)]
	internal struct Struct4
	{
	}

	// Token: 0x0200000C RID: 12
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 448)]
	internal struct Struct5
	{
	}
}
