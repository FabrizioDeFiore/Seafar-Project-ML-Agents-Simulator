<a name="readme-top"></a>
<p align="center"> 
<a><img alt="Static Badge" src="https://img.shields.io/badge/1.4-maker?style=for-the-badge&logo=github&logoColor=white&label=version&color=lightblue"></a>
<a><img alt="Static Badge" src="https://img.shields.io/badge/23%2F06%2F2024-maker?style=for-the-badge&logo=clockify&logoColor=white&label=last%20edited&color=violet"></a>
<a><img alt="Static Badge" src="https://img.shields.io/badge/python-maker?style=for-the-badge&logo=python&logoColor=red&label=language&labelColor=white&color=red"></a>
<a><img alt="Static Badge" src="https://img.shields.io/badge/c%23-maker?style=for-the-badge&logo=c%23&logoColor=green&label=language&labelColor=white&color=green"></a>
<a href="https://www.linkedin.com/in/fabrizio-de-fiore/"><img alt="Static Badge" src="https://img.shields.io/badge/Linkedin-maker?style=for-the-badge&logo=linkedin&color=blue"></a>
</p>


<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a>
    <img src="https://github.com/FabrizioDeFiore/Seafar-Project-ML-Agents-Simulator/assets/78561254/14488746-7ea6-47ea-a5c9-1f0619d10854" alt="Logo" ">
  </a>
  <h1 align="center">Seafar-Project-ML-Agents-Simulator</h1> 
  <p align="center">
    Python-Unity pipeline that transforms dry numerical data into engaging 3D object animations within a Unity environment    <br />
    <br />
    <br />
  </p>
</div>



<!-- TABLE OF CONTENTS -->
  <summary>Table of Contents</summary>
  <ol>
    <li><a href="#project-description">Project description</a> </li>
      <ul>
        <li><a href="#introduction">Introduction</a></li>
        <li><a href="#Unity-and-ML-Agents">Unity and ML Agents</a></li>
      </ul>
    <li><a href="#Set Up">Set Up</a></li>
      <ul>
        <li><a href="#installation">Installation</a></li>
        <li><a href="#training">Training</a></li>
      </ul>
    <li><a href="#My-training-environemnts">My Training Environment</a></li>
      <ul>
        <li><a href="#reinforcement-learning">Reinforcement Learning</a></li>
        <li><a href="#Combined-Learning:-Imitation-+-Reinforcement">Combined Learning: Imitation + Reinforcement</a></li>
      </ul>
    <li><a href="#VR-scene-implementation">VR Scene Implementation</a></li>
    <li><a href="#Conclusion-&-future-application">Conclusion & Future Application</a></li>
  </ol>



# Project description

## Introduction
This project seeks to develop a visually immersive simulation for the Seafar project.<br>
This simulation will utilize Unity Machine Learning Agents (ML-Agents) to leverage the power of both reinforcement learning and imitation learning techniques.

The ultimate objective is to provide users with the flexibility to choose between three distinct perspectives:
- Third-person perspective in a 3D environment.
- First-person view within a virtual reality (VR) experience.
- First-person view within an augmented reality (AR) experience that integrates a live stream from the actual vessel.

**NOTE:** As the live streaming component of the Seafar project is still under development, the current project has been strategically divided into two phases:
- 3D Version: The 3D version serves as the foundational element of the entire project. It is within this environment that the reinforcement learning and imitation learning models are trained. This training process equips the models with the necessary decision-making capabilities and behaviors that will be crucial for the VR and future AR integrations. Additionally, the 3D version serves as the core structure upon which the VR and AR functionalities will be built. This approach ensures a cohesive and efficient development process.
The 3D environment provides users with a visually rich and interactive platform to experience the simulated world. They can navigate this environment from a third-person perspective, allowing for a comprehensive understanding of the simulated scenarios. This initial phase focuses on establishing a robust and well-trained foundation for the subsequent development of the VR and AR experiences.
- VR Version with AR Functionality: This version offers a first person perspective in VR and it's prepared to integrate the live stream functionality from the vessel once the streaming component is complete.

This project presented a valuable opportunity to delve deeper into the mechanics of machine learning (ML) and artificial intelligence (AI).  Through this exploration, I have significantly broadened my understanding of these rapidly evolving fields. <br> 
The project has further ignited my passion for the field of AI development. <br> The process of working with these technologies has been highly rewarding, and I am eager to continue exploring their potential in future projects.

## Unity and ML Agents
The Unity Machine Learning Agents Toolkit (ML-Agents Toolkit) is an open-source project that enables games and simulations to serve as environments for training intelligent agents. Agents can be trained using reinforcement learning, imitation learning, neuroevolution, or other machine learning methods through a simple-to-use Python API. It also provide implementations (based on PyTorch) of state-of-the-art algorithms to enable game developers and hobbyists to easily train intelligent agents for 2D, 3D and VR/AR games. These trained agents can be used for multiple purposes, including controlling NPC behavior (in a variety of settings such as multi-agent and adversarial), automated testing of game builds and evaluating different game design decisions pre-release. 
The ML-Agents Toolkit is mutually beneficial for both game developers and AI researchers as it provides a central platform where advances in AI can be evaluated on Unity’s rich environments and then made accessible to the wider research and game developer communities.


# Set Up

The ML-Agents Toolkit contains several components:

- Unity package ([`com.unity.ml-agents`](https://github.com/Unity-Technologies/ml-agents/tree/develop/com.unity.ml-agents)) contains the
  Unity C# SDK that will be integrated into your Unity project.  This package contains
  a sample to help you get started with ML-Agents.
- Unity package
  ([`com.unity.ml-agents.extensions`](https://github.com/Unity-Technologies/ml-agents/tree/develop/com.unity.ml-agents.extensions))
  contains experimental C#/Unity components that are not yet ready to be part
  of the base `com.unity.ml-agents` package. `com.unity.ml-agents.extensions`
  has a direct dependency on `com.unity.ml-agents`.
- Two Python packages:
  - [`mlagents`](https://github.com/Unity-Technologies/ml-agents/tree/develop/ml-agents) contains the machine learning algorithms that
    enables you to train behaviors in your Unity scene. Most users of ML-Agents
    will only need to directly install `mlagents`.
  - [`mlagents_envs`](https://github.com/Unity-Technologies/ml-agents/tree/develop/ml-agents-envs) contains a set of Python APIs to interact with
    a Unity scene. It is a foundational layer that facilitates data messaging
    between Unity scene and the Python machine learning algorithms.
    Consequently, `mlagents` depends on `mlagents_envs`.
- Unity [Project](https://github.com/Unity-Technologies/ml-agents/tree/main/Project/) that contains several
  [example environments](https://github.com/Unity-Technologies/ml-agents/blob/develop/docs/Learning-Environment-Examples.md) that highlight the
  various features of the toolkit to help you get started.

## Installation

To install and use the ML-Agents Toolkit you will need to:

### - Install Unity (2023.2 or later)
  
[Download](https://unity3d.com/get-unity/download) and install Unity. It's
strongly recommended that you install Unity through the Unity Hub.

### - Install Python (3.10.12 or higher)

It's recommended [installing](https://www.python.org/downloads/) Python 3.10.12.
If you are using Windows, please install the x86-64 version and not x86.
If your Python environment doesn't include `pip3`, see these
[instructions](https://packaging.python.org/guides/installing-using-linux-tools/#installing-pip-setuptools-wheel-with-linux-package-managers)
on installing it. It's also recommended using [conda](https://docs.conda.io/en/latest/) or [mamba](https://github.com/mamba-org/mamba) to manage your python virtual environments.

Once conda has been installed in your system, open a terminal and execute the following commands to setup a python 3.10.12 virtual environment
and activate it.

```shell
conda create -n mlagents python=3.10.12 && conda activate mlagents
```

### - Clone the [ML-Agents Toolkit Repository](https://github.com/Unity-Technologies/ml-agents) (Optional)

Now that you have installed Unity and Python, you can now install the Unity and
Python packages. You do not need to clone the repository to install those
packages, but you may choose to clone the repository if you'd like download the
example environments and training configurations to experiment with them

```sh
git clone --branch release_21 https://github.com/Unity-Technologies/ml-agents.git
```

### - Install the `com.unity.ml-agents` Unity package

The Unity ML-Agents C# SDK is a Unity Package. You can install the
`com.unity.ml-agents` package
[directly from the Package Manager registry](https://docs.unity3d.com/Manual/upm-ui-install.html).
Please make sure you enable 'Preview Packages' in the 'Advanced' dropdown in
order to find the latest Preview release of the package.

### - Install the `com.unity.ml-agents.extensions` Unity package (Optional)

To install the `com.unity.ml-agents.extensions` package, you need to first
clone the repo and then complete a local installation similar to what was
outlined in the previous
Complete installation steps can be found in the
[package documentation](https://github.com/Unity-Technologies/ml-agents/blob/develop/com.unity.ml-agents.extensions/Documentation~/com.unity.ml-agents.extensions.md#installation).

### - Install the `mlagents` Python package

Installing the `mlagents` Python package involves installing other Python
packages that `mlagents` depends on. So you may run into installation issues if
your machine has older versions of any of those dependencies already installed.
Consequently, the supported path for installing `mlagents` is to leverage Python
Virtual Environments. Virtual Environments provide a mechanism for isolating the
dependencies for each project and are supported on Mac / Windows / Linux.

- (Windows) Installing PyTorch
  
On Windows, you'll have to install the PyTorch package separately prior to
installing ML-Agents in order to make sure the cuda-enabled version is used,
rather than the CPU-only version. Activate your virtual environment and run from
the command line:

```sh
pip3 install torch~=2.2.1 --index-url https://download.pytorch.org/whl/cu121
```

Note that on Windows, you may also need Microsoft's
[Visual C++ Redistributable](https://support.microsoft.com/en-us/help/2977003/the-latest-supported-visual-c-downloads)
if you don't have it already. See the [PyTorch installation guide](https://pytorch.org/get-started/locally/)
for more installation options and versions.

- Installing `mlagents`

To install the `mlagents` Python package, activate your virtual environment and
run from the command line:

```sh
cd /path/to/ml-agents
python -m pip install ./ml-agents-envs
python -m pip install ./ml-agents
```

Note that this will install `mlagents` from the cloned repository, _not_ from the PyPi
repository. If you installed this correctly, you should be able to run
`mlagents-learn --help`, after which you will see the command
line parameters you can use with `mlagents-learn`.

**NOTE:** Since ML-Agents development has slowed, PyPi releases will be less frequent. However, you can install from PyPi by executing
the following command:

```shell
python -m pip install mlagents==1.0.0
```

which will install the latest version of ML-Agents and associated dependencies available on PyPi. Note, you need to have the matching version of
the Unity packages with the particular release of the python packages. You can find the release history [here](https://github.com/Unity-Technologies/ml-agents/releases)

By installing the `mlagents` package, the dependencies listed in the
[setup.py file](https://github.com/Unity-Technologies/ml-agents/blob/develop/ml-agents/setup.py) are also installed. These include PyTorch


## Training

After a complete set-up, you can start your training with this simple commands

```shell
cd /path/to/Unity/Project
conda activate mlagents
mlagents-learn ml-agents/config/ppo/MyYamlFileName.yaml --run-id=MyId
```

This command will start a training following your YAML configuration file. 
To resume your training simply type:

```shell
mlagents-learn ml-agents/config/ppo/MyYamlFileName.yaml --resume
```

Once the training is started, you should see something like this: 
<p align="center"> <img  src="https://github.com/FabrizioDeFiore/Seafar-Project-ML-Agents-Simulator/assets/78561254/58c58d14-39ac-43ad-be30-c782d7242b43" > </p>



# My Training Environment

## Reinforcement Learning

As this was my first foray into using ML-Agents, I began with a stripped-down environment containing just the vessel, a goal, and some walls. <br>
Here, I used reinforcement learning to train the vessel to reach the goal from any starting position.
Fine-tuning the reward system proved to be the most challenging aspect. I implemented penalties for excessive time consumption, straying from the goal, and wall collisions. Conversely, rewards were given for getting closer and ultimately reaching the goal, motivating the agent to navigate effectively.
To prevent overfitting to a single scenario, both the agent and goal spawn locations were randomized at each episode restart. This forced the agent to develop robust pathfinding skills. To accelerate training, I also multiplied the number of simulated environments.

### How it started 

<div align="center"><video src="https://github.com/FabrizioDeFiore/Seafar-Project-ML-Agents-Simulator/assets/78561254/007835d8-d11a-401c-8626-709862453e76"> </div>

The reward system's mathematical structure presented some initial hurdles. Initially, the agent displayed a preference for colliding with the walls immediately, potentially due to the time penalty outweighing the immediate penalty for a collision.
After addressing this behavior, a new challenge arose: the agent favored staying in the center to avoid collision penalties altogether. Through persistent experimentation, I successfully fine-tuned the reward system to achieve the desired balance, ultimately leading to successful model training.

### How it become 

<div align="center"><video src="https://github.com/FabrizioDeFiore/Seafar-Project-ML-Agents-Simulator/assets/78561254/a6327a94-7488-4ca0-9c48-d086ac52b8c0"> </div>

## Combined Learning: Imitation + Reinforcement

Following successful initial training, the environment underwent a significant transformation. It now features a more intricate and realistic path layout, replicating a more complex and practical scenario. To further enhance the training process, I incorporated several advanced technologies:
* Combined Learning: The system now utilizes both reinforcement learning, the initial approach, and imitation learning. This allows the agent to learn not only through trial and error but also by observing and emulating pre-defined expert behaviors and even improving them.
* Checkpoint Rewards: A checkpoint system for rewards was implemented. This introduces additional reward opportunities at specific points along the path, encouraging the agent to consistently progress towards the goal.
* Non-contact Perception: A ray perception sensor was integrated, enabling the agent to analyze the surrounding environment without the risk of collision. This provides valuable information for the agent to navigate effectively.
T
Leveraging combined learning techniques significantly accelerated the agent's learning process. It quickly grasped the essential pathfinding strategies, enabling it to navigate the course much faster. Once it mastered circuit completion, the agent continuously refined its performance, surpassing my initial demonstrations.

I've included my config.yaml file. This configuration file details the relative strengths assigned to the different learning reward signals (e.g., reinforcement learning, imitation learning) employed in the project.

<p align="center"> <img  src="https://github.com/FabrizioDeFiore/Seafar-Project-ML-Agents-Simulator/assets/78561254/461bd13a-de6f-4f02-8af0-cd1778198271" > </p>



### How it started

# VR Scene Implementation


# Conclusion & Future Application

