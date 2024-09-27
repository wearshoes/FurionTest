问题描述：
选项更改通知，在使用局部注入IOptionsMonitor的方式的情况下依然会多次触发，在发布和非发布模式都可复现。

复现流程：
1.运行项目
2.在Restapi中执行/api/system/description
3.修改appsetting.json中subaddress的值

