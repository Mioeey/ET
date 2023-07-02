﻿using System;

namespace ET
{
	[Flags]
	public enum SceneType: long
	{
		None = 0,
		Process = 1,
		Manager = 1 << 2,
		Realm = 1 << 3,
		Gate = 1 << 4,
		Http = 1 << 5,
		Location = 1 << 6,
		Map = 1 << 7,
		Router = 1 << 8,
		RouterManager = 1 << 9,
		Robot = 1 << 10,
		BenchmarkClient = 1 << 11,
		BenchmarkServer = 1 << 12,
		Benchmark = 1 << 13,
		Match = 1 << 14,
		Room = 1 << 15,
		LockStepClient = 1 << 16,
		LockStepServer = 1 << 17,
		Main = 1 << 18, // 主纤程,一个进程一个, 初始化从这里开始
		NetInner = 1 << 19,  // 负责进程间消息通信
		RoomRoot = 1 << 20,

		// 客户端
		Demo = 1 << 30,
		Current = 1L << 31,
		LockStep = 1L << 32,
		LockStepView = 1L << 33,
		DemoView = 1L << 34,

		All = long.MaxValue,
	}

	public static class SceneTypeHelper
	{
		public static bool HasSameFlag(this SceneType a, SceneType b)
		{
			if (((ulong) a & (ulong) b) == 0)
			{
				return false;
			}
			return true;
		}
	}
}