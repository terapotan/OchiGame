import unittest

class testMain(unittest.TestCase):
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

if __name__ == '__main__':
    unittest.main(exit=False)
    import gameTitle
    input()
    
    