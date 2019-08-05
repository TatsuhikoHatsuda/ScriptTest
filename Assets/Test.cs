using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
    private int hp = 100;       // 体力
    private int power = 25;     // 攻撃力
    private int mp = 53;        // マジックポイント

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

    // 魔法用の関数
    public void Magic() {
        // 残りMPが5以上で魔法発動
        if (mp >= 5) {
            // 残りMPを減らす
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }
        else {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
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

        // 魔法を10回使う
        for (int i = 0; i < 10; i++) {
            lastboss.Magic();
        }
        // さらにもう一回使う(MPが足りないため発動しない)
        lastboss.Magic();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
