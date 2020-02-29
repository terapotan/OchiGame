import unittest

class testMain(unittest.TestCase):
    def test_canMoveStageSelectScene(self):
        self.assertEqual(input('タイトル画面からステージ選択画面に移動できるか'),'y')

unittest.main(exit=False)    
    