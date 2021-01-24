コミット: dc53cc203ed8519ede4cdcca8ff9f2b8bcfa6e60 [dc53cc2]
日時: 2021年1月24日 22:14:31
★リザルト画面のUI修正、背景画像の設定
・リザルト画面にて、NewRecordメッセージに点滅アニメーション、背景画像の設定追加とCanvasをカメラ視点を元に設定変更など
Assets\Scenes\03_Result.unity
・Canvas設定の影響でUIの選択切り替えに不具合が出た為、修正。
Assets\Scripts\ScImageSwitch.cs
Assets\Scripts\Beans\CsRectTransformBean.cs
・NewRecordのオブジェクトUIの名前を追加
Assets\Scripts\Common\CsNormalLevelDesignOfCommon.cs
・リザルト画面用の背景画像を作成
Assets\Images\Background_03_Result_01.png
・NewRecordメッセージに点滅アニメーションを制御するスクリプトクラス
Assets\Scripts\ScResultUIAnimation.cs

コミット: 0e35c646b449b511023570ecb101ac8ebbbd5152 [0e35c64]
日時: 2021年1月24日 19:06:40
★タイトル画面へ戻るボタンに対してシーン移動機能を実装
・リザルト画面にて、ボタンUIの情報変更（トリガー追加など）
Assets\Scenes\03_Result.unity
・コントローラー操作にて、UIが選択できるように修正。既存選択条件を修正。
Assets\Scripts\ScImageSwitch.cs
・定義クラスへタイトル画面のシーン名、InputManager設定の一部キーの名前を追加
Assets\Scripts\Common\CsNormalLevelDesignOfCommon.cs
・UI切り替え制御クラスにて、フラグ条件を追加
Assets\Scripts\Common\CsNormalLogicDesignOfUIVisualController.cs
・InputManagerにて、コントローラーの十字キー設定を追加。決定キーの設定を変更。
ProjectSettings\InputManager.asset
・ボタンUIをクリックした際に、タイトル画面へ遷移する処理を追加
Assets\Scripts\ScReturnTitle.cs

コミット: bb5ae4122c83b85e04bdb3a67561a9187d1506bb [bb5ae41]
日時: 2021年1月24日 15:23:30
★リザルト画面へUIを配置して、UI選択制御を実装
・リザルト画面にて、メッセージやタイトル画面へ戻るボタンを配置
Assets\Scenes\03_Result.unity
・定義クラスへTransformの初期値、Scaleの初期値を追加
Assets\Scripts\Common\CsNormalLevelDesignOfCommon.cs
・リザルト画面にて使用するUIの画像データを作成
Assets\Images\Logo_03_Result_NEWRECORD!!.png
Assets\Images\Logo_03_Result_RESULT.png
Assets\Images\Logo_03_Result_TITLE_01.png
Assets\Images\Logo_03_Result_TITLE_02.png
Assets\Images\Logo_03_Result_TITLE_03.png
Assets\Images\Logo_03_Result_YOURTIME.png
・UIに対して選択状態で見た目が変化する処理を制御するスクリプトを作成
Assets\Scripts\ScImageSwitch.cs
・インスペクター情報を管理するBeanクラスを作成
Assets\Scripts\Beans\CsInspectorBean.cs
・RectMask2Dコンポーネント情報を管理するBeanクラスを作成
Assets\Scripts\Beans\CsRectMask2DBean.cs
・RectTransformコンポーネント情報を管理するBeanクラスを作成
Assets\Scripts\Beans\CsRectTransformBean.cs
・UI表示の制御するクラスを作成
Assets\Scripts\Common\CsNormalLogicDesignOfUIVisualController.cs
・UIの選択状態ステータスを表現するEnumを作成
Assets\Scripts\Enums\EnumSwitchStaus.cs
・Beanのマップのキーを表現するEnumを作成
Assets\Scripts\Enums\EnumUIBeanKeys.cs

コミット: 7d954e6a1bcdb7338157d4990a3671ec9b5a4085 [7d954e6]
日時: 2021年1月23日 15:53:08
★ゴール判定用オブジェクトへ触れるとリザルト画面シーンへ移動する機能を追加
・ゴール判定用オブジェクトの設定を変更
Assets\Scenes\02_Stage001.unity
・ゴール判定スクリプトへリザルト画面へシーン遷移する処理を追加
Assets\Scripts\ScGoalSequence.cs
・プレイヤーオブジェクト名とリザルト画面シーン名の文字列型定数を追加
Assets\Scripts\Common\CsNormalLevelDesignOfCommon.cs

コミット: 82131702384923bc3e5227527289f24ca3d02d6d [8213170]
日時: 2021年1月23日 14:42:23
★落下時にスタート位置に戻る機能を追加と開発版にライセンスロゴ表記
・ゲーム画面にライセンス表記など
Assets\Scenes\02_Stage001.unity
・落下判定を追加して、スタートポイントへ戻るように変更
Assets\Standard Assets\Characters\ThirdPersonCharacter\Scripts\ThirdPersonCharacter.cs
Assets\Standard Assets\Characters\ThirdPersonCharacter\Scripts\CsTransformBean.cs

コミット: e3564afbe580171a3e7cfd2df3a9eca48f289c58 [e3564af]
日時: 2021年1月21日 22:52:36
★プレイヤーメカニクスの不具合を修正
・作業メモ追加
StudyNote.txt
・プレイヤーの高さのColider設定を変更
Assets\Scenes\02_Stage001.unity
・プレイヤー操作ロジック変更（対空状態で少し移動できるように、段差に当たりながらジャンプしても乗り越え可能、ブロックの端に嵌った際に向いた方向に移動可能）
Assets\Standard Assets\Characters\ThirdPersonCharacter\Scripts\ThirdPersonCharacter.cs

コミット: 5aea0b955b51b551f6ab156637ebbd092551a367 [5aea0b9]
日時: 2021年1月17日 21:03:29
★ベルトコンベアの動きに軽微な修正
・マテリアル座標移動のメモ
StudyNote.txt
・マテリアル設定など
Assets\Scenes\02_Stage001.unity
・マテリアルをスクロールする処理を追加
Assets\Scripts\ScConveyor.cs
・マテリアル設定変更
Assets\WorldMaterialsFree\BathroomTiles_StandardShader.mat

コミット: 2acf7489690f250d5f4318979af265df78dfa674 [2acf748]
日時: 2021年1月17日 18:37:41
★メインゲーム画面にて、全オブジェクトに対してマテリアルを適用
・弾のPrefabへMaterialsを追加
Assets\Prefab\SpBulletCenter.prefab
Assets\Prefab\SpBulletLeft001.prefab
Assets\Prefab\SpBulletLeft002.prefab
Assets\Prefab\SpBulletRight001.prefab
Assets\Prefab\SpBulletRight002.prefab
・オブジェクトへマテリアルセットの影響
Assets\SampleScenes\Materials\OrangeSmooth.mat
Assets\Standard Assets\Prototyping\Materials\PinkSmooth.mat
Assets\Standard Assets\Prototyping\Materials\YellowSmooth.mat
・ステージ全体へMaterialsを追加
Assets\Scenes\02_Stage001.unity
・青色マテリアルを追加
Assets\Materials\TileColor_Blue.mat
・紫色マテリアルを追加
Assets\Materials\TileColor_purple.mat
・WorldMaterialsFreeのアセットを追加
Assets\WorldMaterialsFree

コミット: 04a59b2702a09502f492e3f6664c5e54e6c13181 [04a59b2]
日時: 2021年1月16日 23:19:12
・メインゲーム画面にて、配置漏れオブジェクトを配置
Assets\Scenes\02_Stage001.unity
・ProBuilderウィンドウ閉じたことによる変更
ProjectSettings\Packages\com.unity.probuilder\Settings.json

コミット: c4058db7828e5be75fafd60a3a81d0c562d4c50d [c4058db]
日時: 2021年1月16日 17:38:32
・作業メモを追記
StudyNote.txt
・メインステージ画面作成（7割完成）
ステージ頂上とゴール辺りを追加
大砲・回転パネル・自動回転お邪魔オブジェクトを配置
スタート地点の床に穴を空けるetc...
Scenes\02_Stage001.unity
・カメラスクリプトへ警告エラーを消す記述を追加
Assets\Scripts\ScCinemachineControll.cs
・大砲や自動回転お邪魔オブジェクトに関する定数を追加
Assets\Scripts\Common\CsNormalLevelDesignOfCommon.cs
・ProBuilderのアセット追加
Packages\manifest.json
Packages\packages-lock.json
ProjectSettings\Packages\com.unity.probuilder\Settings.json
・衝突判定の為のMaterialを作成
Assets\Physics Matetials\PmConveyor.physicMaterial
・正三角形のPrefabを作成
Assets\Prefab\EquilateralTriangle.prefab
・大砲のPrefabを作成
Assets\Prefab\GoCannon.prefab
・自動回転お邪魔オブジェクトのPrefabを作成
Assets\Prefab\GoMotor.prefab
・直角三角形のPrefabを作成
Assets\Prefab\IsoscelesTriangle.prefab
・弾（中心）のPrefabを作成
Assets\Prefab\SpBulletCenter.prefab
・弾（左１）のPrefabを作成
Assets\Prefab\SpBulletLeft001.prefab
・弾（左２）のPrefabを作成
Assets\Prefab\SpBulletLeft002.prefab
・弾（右１）のPrefabを作成
Assets\Prefab\SpBulletRight001.prefab
・弾（右２）のPrefabを作成
Assets\Prefab\SpBulletRight002.prefab
・大砲から弾を生成するスクリプト作成
Assets\Scripts\ScBulletCreate.cs
・弾を飛ばして一定時間後に破壊するスクリプト作成
Assets\Scripts\ScBulletShot.cs
・ベルトコンベア制御のスクリプト作成
Assets\Scripts\ScConveyor.cs
・ゴール制御のスクリプト作成（ゴールシーンへは未遷移）
Assets\Scripts\ScGoalSequence.cs
・自動回転お邪魔オブジェクトの回転制御スクリプト作成
Assets\Scripts\ScMotorSpin.cs
・タイマーBeanを作成
Assets\Scripts\Beans\CsTimerBean.cs
・Transform情報のBeanを作成
Assets\Scripts\Beans\CsTransformBean.cs
・初期値を設定するクラスを作成
Assets\Scripts\Common\CsNormalLogicDesignOffSets.cs

コミット: 8e89968a7249072f0091c6ef7811ada1dc384885 [8e89968]
日時: 2021年1月9日 14:14:13
・メインゲーム画面にゲームオブジェクトを配置（途中）
Assets\Scenes\02_Stage001.unity
・回転オブジェクトをPrefab化
Assets\Prefab\GoSpin001.prefab

コミット: cbff91edc06da719b6e5d1e241edf705d7207a5a [cbff91e]
日時: 2021年1月3日 12:47:30
・Cinemachine設定を変更
Assets\Scenes\02_Stage001.unity
・コントローラー設定を変更。左スティック操作と右スティック操作の設定を変更。
ProjectSettings\InputManager.asset
・コントローラーの右スティックで視点制御するスクリプトを作成
Assets\Scripts\ScCinemachineControll.cs
・全体のパラメータ情報を管理する定数クラスを作成。上下、左右の意味を表す文字列を追加。
Assets\Scripts\Common\CsNormalLevelDesignOfCommon.cs

コミット: 3a6cee9f5d87cc7b4f1581572f082f9ef4f23c9a [3a6cee9]
日時: 2021年1月2日 23:09:23
・タイトルシーンにてユニティちゃん使用ライセンスの記載
Assets\Scenes\01_Title.unity
・ゲーム画面にてユニティちゃん、Cinemachineカメラ、操作確認の床を配置
Assets\Scenes\02_Stage001.unity
・コントローラー操作可能にする設定変更
ProjectSettings\InputManager.asset
ProjectSettings\ProjectSettings.asset
・作業メモを作成
StudyNote.txt
・移動、ジャンプ実装の為、Standard AssetsをImport
Assets\Standard Assets
・ダイブモーション用のサンプルモデル（未実装）
Assets\SampleModels\HumanoidDive.fbx
・プレイヤーモデル実装の為、ユニティちゃんをImport
Assets\UnityChan
・ユニティちゃん使用ライセンス
License\01Unity-Chan License Terms and Condition_JP_UCL2.0.pdf
License\02Unity-Chan License Terms and Condition_Summary_JP_UCL2.0.pdf
License\03Indication of License_JP_UCL2.0.pdf
・他アセット導入の付属ファイル等
Assets\Images
Assets\SampleScenes

コミット: 5ce8ed100ef8dbd2f131e6175735501cef4aa2ea [5ce8ed1]
日時: 2020年12月30日 21:45:58
・タイトルシーンの作成
Assets\Scenes\01_Title.unity
・ゲーム画面シーンの作成
Assets\Scenes\02_Stage001.unity
・リザルト画面シーンの作成
Assets\Scenes\03_Result.unity
・タイトルシーン、ゲーム画面シーン、リザルト画面シーンをビルド設定
ProjectSettings\EditorBuildSettings.asset
