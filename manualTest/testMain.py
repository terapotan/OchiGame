import unittest

class testMain(unittest.TestCase):
    def test_canMoveAndroid(self):
        self.assertEqual(input('アンドロイド君を→と←に動かせるか(y/n)'),'y')
    def test_fallManyArrows(self):
        self.assertEqual(input('矢がたくさん降ってくるか(y/n)'),'y')
    def test_getScreenHeightPoint(self):
        self.assertEqual(input('画面の一番下の座標が表示されているか(y/n)'),'y')
    def test_destoryArrow(self):
        self.assertEqual(input('矢が画面外に出たら矢が消滅しているか(y/n)'),'y')

if __name__ == '__main__':
    unittest.main(exit=False)
    input()
    
    