import unittest

class itemActionTest(unittest.TestCase):
    def test_fallStartItem(self):
        self.assertEqual(input('スターのアイテムが落ちてくるか(y/n)'),'y')
    def test_fallSpeedUpItem(self):
        self.assertEqual(input('スピードアップのアイテムが落ちてくるか(y/n)'),'y')
    def test_fallSpeedDownItem(self):
        self.assertEqual(input('スピードダウンのアイテムが落ちてくるか(y/n)'),'y')
    def test_fallBullet(self):
        self.assertEqual(input('火の玉が落ちてくるか(y/n)'),'y')
    def test_fallArrow(self):
        self.assertEqual(input('矢は落ちてくるか(y/n)'),'y')

if __name__ == '__main__':
    unittest.main(exit=False)
    input()