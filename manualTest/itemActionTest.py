import unittest

class itemActionTest(unittest.TestCase):
    def test_fallStartItem(self):
        self.assertEqual(input('スターのアイテムが落ちてくるか(y/n)'),'y')
    def test_fallSpeedUpItem(self):
        self.assertEqual(input('スピードアップのアイテムが落ちてくるか(y/n)'),'y')
    def test_fallSpeedDownItem(self):
        self.assertEqual(input('スピードダウンのアイテムが落ちてくるか(y/n)'),'y')
    def test_fallArrow(self):
        self.assertEqual(input('矢は落ちてくるか(y/n)'),'y')
    def test_fallHinotama(self):
        self.assertEqual(input('火の玉は落ちてくるか(y/n)'),'y')
    def test_destroyItem(self):
        self.assertEqual(input('ドロイド君とアイテムが当たった時アイテムは消滅するか(y/n)'),'y')

    
    """
    def test_isCheckedCollisionStar(self):
        self.assertEqual(input('ドロイド君とスターが当たったときStarと表示されるか(y/n)'),'y')
    def test_isCheckedCollisionSpeedUp(self):
        self.assertEqual(input('ドロイド君とスピードアップが当たったときSpeedUpと表示されるか(y/n)'),'y')
    def test_isCheckedCollisionSpeedDown(self):
        self.assertEqual(input('ドロイド君とスピードダウンが当たったときSpeedDownと表示されるか(y/n)'),'y')
    def test_isCheckedCollisionBullet(self):
        self.assertEqual(input('ドロイド君と火の玉が当たったときBulletと表示されたか(y/n)'),'y')
    """
if __name__ == '__main__':
    unittest.main(exit=False)
    input()