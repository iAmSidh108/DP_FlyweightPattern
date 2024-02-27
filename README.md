# **Flyweight Pattern in Unity:**

## **What is the Flyweight Pattern?**

The Flyweight Pattern is a structural design pattern that focuses on optimizing memory usage or computational efficiency by sharing objects, reducing redundancy, and making objects more lightweight. It achieves this by separating intrinsic and extrinsic state, where intrinsic state is shared among multiple objects, and extrinsic state is stored separately.

![image](https://github.com/iAmSidh108/DP_FlyweightPattern/assets/63715240/d26150f2-59f0-4d6a-8009-dcd041437311)


## **Examples of using the Flyweight Pattern in game development:**

1. **Terrain Generation:**
   - **Intrinsic State:** Shared information like terrain textures, which is common across multiple terrain objects.
   - **Extrinsic State:** Specific information like the position and size of each terrain object.

2. **Particle Systems:**
   - **Intrinsic State:** Shared particle textures, colors, or shapes.
   - **Extrinsic State:** Position, velocity, and other unique properties of individual particles.

## **Drawbacks of using Flyweight Pattern:**

1. **Complexity:**
   - The pattern may introduce additional complexity, especially when separating intrinsic and extrinsic state.

2. **Trade-off between Memory and Computation:**
   - While it reduces memory usage, it may increase computation due to managing shared state and handling extrinsic state separately.

3. **Learning Curve:**
   - Developers unfamiliar with the pattern may find it challenging to understand and implement, especially in smaller projects.

## **How to implement Flyweight Pattern:**

1. **Identify Shared and Non-Shared State:**
   - Identify which parts of the object's state can be shared among instances (intrinsic) and which parts need to be unique for each instance (extrinsic).

2. **Create Flyweight Interface:**
   - Establish a common interface for all flyweight objects, including methods to set and get extrinsic state.

3. **Implement Concrete Flyweights:**
   - Create classes that implement the flyweight interface, representing shared state.

4. **Manage Extrinsic State Separately:**
   - In the client code, manage and provide extrinsic state separately from the flyweight objects.

5. **Use Flyweights in Client Code:**
   - In the client code, use flyweight objects to represent instances, providing only the unique extrinsic state when needed.

6. **Unity Prefabs:**
   - In Unity, prefabs can be considered a form of the flyweight pattern, where the prefab (intrinsic state) is shared, and instances (extrinsic state) are created with unique positions and configurations.

7. **Documentation:**
   - Clearly document the purpose and usage of flyweight objects, emphasizing the separation of intrinsic and extrinsic state.

## **Real-life Example:**

Consider a text editor where each character in a document is represented as an individual object. The character's font, size, and style are intrinsic and can be shared among characters, while the position and color are extrinsic and unique for each character instance. By using the Flyweight Pattern, the memory usage can be optimized by sharing the common font information across all characters, making the overall system more efficient.

## How I implemented this pattern in the project.

First i created the spawner script for Keypad 1 and 2 with 2 different prefabs.

### Here we have a list of gameObjects that we want to spawn and then set to spawn with Keypad 1 and 2. But this is not optimized.

![image](https://github.com/iAmSidh108/DP_FlyweightPattern/assets/63715240/cfbc65b5-545b-4243-80bf-29f4e7859803)


### This is a FlyWeight script where we define intrinsic state with a scriptable object called FlyweightSettings.cs

![image](https://github.com/iAmSidh108/DP_FlyweightPattern/assets/63715240/ae6a8dd6-fb3d-4438-a6b4-84351b2670c7)

### This is the scriptable object with all the details of the flyweight and these will remain same with all the instances.

![image](https://github.com/iAmSidh108/DP_FlyweightPattern/assets/63715240/2ec05f2b-7958-4711-8804-a7b47b31b71f)

### This is enum with types of prefabs. 

![image](https://github.com/iAmSidh108/DP_FlyweightPattern/assets/63715240/5db8c249-9565-4ef9-abcf-7d337f498a28)

### Changed input settings for instation using Flyweight.

![image](https://github.com/iAmSidh108/DP_FlyweightPattern/assets/63715240/4a69c977-769f-4643-959a-d664061f84b7)

### I optimized it more by creating factory of flyweights and using Object pool.

![image](https://github.com/iAmSidh108/DP_FlyweightPattern/assets/63715240/d55c4631-43d0-4db5-a134-02accaed20bc)

### Here we can see that we created Object pool so that we can spawn and respawn prefabs again and again whenevr required. Also add the methods for objectpool into FlyweightSettings and make some changes in Input to spawn from Factory instead of Flyweight itself. To understand more about Object Pool and Factory pattern. See other repository for both of these patterns. 



