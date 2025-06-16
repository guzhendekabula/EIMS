# 企业信息管理系统
## 概述
企业信息管理系统用于管理企业的客户信息、员工信息、部门信息以及员工与部门的隶属关系。
## 开发工具
1.MySQL中实现数据库，因此在本地导入sql文件后，程序中用到MySQL账号密码部分需要改为你自己MySQL的账号密码才能运行；

2.vs2015实现前端(C#)，开发窗体程序并测试运行。
## 数据库概念设计
数据库具体信息可以通过sql文件查看

E-R图如下：

<img width="482" alt="image" src="https://github.com/user-attachments/assets/49e14773-0716-4b73-9ed3-3f228951f46c" />

## 登录界面
登录界面中，输入工号和密码可以进行登陆验证，验证成功则进入主页面，否则提示工号或密码不正确，请重新输入。这里工号输入1，密码输入333即可。

<img width="175" alt="image" src="https://github.com/user-attachments/assets/9856712b-12c2-4c53-aa98-522d3c95efb1" />

## 主页面
<img width="209" alt="image" src="https://github.com/user-attachments/assets/9a08f172-d37f-4a4f-ac36-e8d3c46459d3" />

## 客户信息管理页面
实现了加载、添加、修改、删除客户信息。

<img width="156" alt="image" src="https://github.com/user-attachments/assets/7e3e1821-f5a4-4b21-b72f-5d217b864bae" />

## 员工信息管理页面
实现了加载、添加、修改、删除员工信息。

<img width="201" alt="image" src="https://github.com/user-attachments/assets/89f80a95-e353-4b68-a88b-b4640a9f3151" />

## 部门信息管理页面
实现了加载、添加、修改、删除部门信息。

<img width="173" alt="image" src="https://github.com/user-attachments/assets/9df2183d-b457-4553-b44a-2624d9367fd4" />

## 员工-部门隶属信息管理页面
实现了加载员工-部门隶属信息，可以为员工分配部门，并处理一个员工可以属于多个部门的情况。

<img width="318" alt="image" src="https://github.com/user-attachments/assets/4d301026-8b0d-412a-8d7d-bb2a7dd9def7" />

## 查询员工页面
实现了多条件查询员工信息，如按姓名、入职日期、所属部门等。

<img width="284" alt="image" src="https://github.com/user-attachments/assets/5f4c3a9d-c767-4925-92ea-7701b65f4153" />

## 查询员工部门信息页面
实现了加载指定员工的部门信息

<img width="285" alt="image" src="https://github.com/user-attachments/assets/f6e74cb5-fb04-4cc0-972d-908f03d2b741" />

