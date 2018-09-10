# 设计模式学习笔记 

## 策略模式 Strategy Pattern

### 定义

建立算法族，分别封装起来，让它们可用互相替换，让算法的变化独立于使用算法的客户

### 设计原则

**系统中的某部分改变不会影响其他部分** 封装变化的部分，便于后续扩展，隔离不需要变化的部分

**针对接口、抽象类编程** 而不是针对实现编程,即多态

**多用组合，少用继承** 使用组合建立的弹性系统，将算法族封装成类，在运行时动态地改变行为

[Demo](https://github.com/ryuuc/CSharp-Design-Patterns/tree/master/CSharpDesignPatterns/StrategyPattern)
