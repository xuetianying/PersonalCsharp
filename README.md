# PersonalCsharp
## Git与VsCode相关操作 
- git仓库操作（新建）
echo "# PersonalCsharp" >> README.md
git init
git add README.md
git commit -m "first commit"
git remote add origin https://github.com/xuetianying/PersonalCsharp.git
git push -u origin master
- git仓库操作（已经存在时）
git remote add origin https://github.com/xuetianying/PersonalCsharp.git
git push -u origin master
- 从其他仓库导入
You can initialize this repository with code from a Subversion, Mercurial, or TFS project.
- vscode使用基本步骤
    - 1.先pull拉取最新数据
    - 2.暂存数据
    - 3.提交（可以跟第二步合并）
    - 4.push推送到远程端
## dotnet core 常用工具类的封装
- 用xuint作为单元测试工具
 