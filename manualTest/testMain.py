import unittest

class testMain(unittest.TestCase):
    """
    def test_canMoveAndroid(self):
        self.assertEqual(input('アンドロイド君を→と←に動かせるか(y/n)'),'y')
    def test_fallManyArrows(self):
        self.assertEqual(input('矢がたくさん降ってくるか(y/n)'),'y')
    def test_destoryArrow(self):
        self.assertEqual(input('矢が画面外に出たら矢が消滅しているか(y/n)'),'y')
    def test_decTimer(self):
        self.assertEqual(input('タイマーの数値が時間と共に減少しているか(y/n)'),'y')
    def test_isCleared(self):
        self.assertEqual(input('タイマーの数値が0になったらクリア画面に移動するか(y/n)'),'y')
    def test_isGameOvered(self):
        self.assertEqual(input('ドロイド君が矢に当たったらゲームオーバー画面に飛ぶか(y/n)'),'y')
    """
    def test_canMoveStageSelectScene(self):
        self.assertEqual(input('タイトル画面からステージ選択画面へ移動出来るか(y/n)'),'y')
    def test_canMoveGameTitleScene(self):
        self.assertEqual(input('ステージ選択画面からタイトル画面に移動できるか(y/n)'),'y')
    def test_canMoveStageSelectSceneInGameOver(self):
        self.assertEqual(input('ゲームオーバー画面からステージ選択画面に戻れるか(y/n)'),'y')
    def test_canMoveStageSelectSceneInGameClear(self):
        self.assertEqual(input('ステージクリア画面からステージ選択画面に戻れるか(y/n)'),'y')

if __name__ == '__main__':
    unittest.main(exit=False)
    input()
    
    