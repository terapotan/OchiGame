import subprocess

#事前にソリューション全体を
#テスト対象:Test
#自動テスト実行クラス:Debug
#でビルドしておく。その後このプログラムを起動させる。

#テスト対象プロジェクトをDebugでビルド
#buildTestedProject = subprocess.run("MSBuild /p:Configuration=Debug ./TestedProject/TestedProject/TestedProject.vcxproj",shell=True)
#テストを実行
#runTest = subprocess.run("vstest.console ./TestedProject/Debug/UnitTest1.dll",shell=True)
#テスト対象プロジェクトを実行(手動テストのため)
#runTestedProject = subprocess.run("cd ./TestedProject/Debug&TestedProject.exe",shell=True)
#入力待機
#input()