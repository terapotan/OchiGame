import unittest

class playStageLoad(unittest.TestCase):
    def test_beforeStartingStage(self):
        self.assertEqual(input('ステージのプレイが始まる前にPress any key start!的なメッセージが表示される(y/n)'),'y')

if __name__ == '__main__':
    unittest.main(exit=False)
    input()