# 设计模式学习笔记 

## 0.策略模式 Strategy Pattern

### 定义

建立算法族，分别封装起来，让它们可用互相替换，让算法的变化独立于使用算法的客户

### 设计原则

**系统中的某部分改变不会影响其他部分** 封装变化的部分，便于后续扩展，隔离不需要变化的部分

**针对接口、抽象类编程** 而不是针对实现编程,即多态

**多用组合，少用继承** 使用组合建立的弹性系统，将算法族封装成类，在运行时动态地改变行为

[Demo](https://github.com/ryuuc/CSharp-Design-Patterns/tree/master/CSharpDesignPatterns/StrategyPattern)

## 1.观察者模式 Observer Pattern

### 定义

观察者模式定义了对象之间的一对多依赖，这样一来，当一个对象改变状态时，它的所有依赖者都会收到通知并自动更新。

### 设计原则

为了交互对象之间的松耦合设计而努力。

[Demo](https://github.com/ryuuc/CSharp-Design-Patterns/tree/master/CSharpDesignPatterns/ObserverPattern)

## 2.装饰者模式 Decorator Pattern

### 定义

动态地将责任附加到对象上，若要扩展功能，装饰者提供了比继承更有弹性的替代方案。

### 设计原则

**类应该对扩展开放，对修改关闭**

#### 关键点

装饰者和被装饰者对象有系统的基类

可以用一个或多个装饰者包装一个对象

装饰者可以在所委托被装饰者的行为之前 与/或 之后，加上自己的行为


