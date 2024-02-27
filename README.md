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

Will be added soon once complete
