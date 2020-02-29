import unittest

class gameTitleTest(unittest.TestCase):
    
    def test_canMoveStageSelectScene(self):
        self.assertEqual(input('タイトル画面からステージ選択画面に移動できるか'),'y')
    
class gameTitle:
    def runTest(self):
        unittest.main(exit=False)

    