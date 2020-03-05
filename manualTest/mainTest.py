import unittest

class mainTest(unittest.TestCase):

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
