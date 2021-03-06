﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * 应用管理接口
 * 系统版本要求1.2.5以上
 */ 
public class CCPmApi {
	/**
	 * 绑定应用管理服务
	 * !! 需要提前调用该方法绑定服务，才能使用install()，可以在应用启动时调用
	 */ 
	public static void bind(){
		using(AndroidJavaClass cls = new AndroidJavaClass("com.coocaa.vr.sdk.CCPmApi")){
			cls.CallStatic<AndroidJavaObject> ("getInstance").Call ("bindService");
		}
	}

	/**
	 * 解绑应用管理服务
	 * !! 退出应用前调用
	 */ 
	public static void unbind(){
		using(AndroidJavaClass cls = new AndroidJavaClass("com.coocaa.vr.sdk.CCPmApi")){
			cls.CallStatic<AndroidJavaObject> ("getInstance").Call ("unbind");
		}
	}

	/**
	 * 应用安装接口
	 * !! 使用前，请先提前调用bind来异步绑定服务。绑定成功后调用才有效。
	 */ 
	public static void install(string appName,string apkPath){
		using(AndroidJavaClass cls = new AndroidJavaClass("com.coocaa.vr.sdk.CCPmApi")){
			cls.CallStatic<AndroidJavaObject> ("getInstance").Call ("install",appName,apkPath);
		}
	}

	/**
	 * 应用卸载接口，未经测试
	 * !! 使用前，请先提前调用bind来异步绑定服务。绑定成功后调用才有效。
	 */ 
	public static void uninstall(string pkgName){
		using(AndroidJavaClass cls = new AndroidJavaClass("com.coocaa.vr.sdk.CCPmApi")){
			cls.CallStatic<AndroidJavaObject> ("getInstance").Call ("uninstall",pkgName);
		}
	}

	/**
	 * 关闭安装应用弹窗，取消安装
	 */ 
	public static void hide(){
		using(AndroidJavaClass cls = new AndroidJavaClass("com.coocaa.vr.sdk.CCPmApi")){
			cls.CallStatic<AndroidJavaObject> ("getInstance").Call ("cancelInstall");
		}
	}

}
