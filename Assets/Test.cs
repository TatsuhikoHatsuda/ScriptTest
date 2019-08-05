﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
    private int hp = 100;       // 体力
    private int power = 25;     // 攻撃力

    // 攻撃用の関数
    public void Attack(){
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage) {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }
}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);

        // 新しいBossクラスの変数を宣言
        Boss midboss = new Boss();

        // 攻撃用の関数を呼び出す
        midboss.Attack();
        // 防御用の関数を呼び出す
        midboss.Defence(20);

        // 配列arrayの宣言と初期化
        int[] array = { 1, 2, 3, 4, 5 };

        // arrayの各要素を順に表示
        for (int i = 0; i < array.Length; i++) {
            Debug.Log(array[i]);
        }
        // arrayの各要素を逆順に表示
        for (int i = array.Length - 1; i >= 0; i--) {
            Debug.Log(array[i]);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
