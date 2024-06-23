<a name="readme-top"></a>
<p align="center"> 
<a><img alt="Static Badge" src="https://img.shields.io/badge/1.4-maker?style=for-the-badge&logo=github&logoColor=white&label=version&color=lightblue"></a>
<a><img alt="Static Badge" src="https://img.shields.io/badge/%2F06%2F2024-maker?style=for-the-badge&logo=clockify&logoColor=white&label=last%20edited&color=violet"></a>
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
cd /path/to/Unity/Project/Directory
conda activate mlagents
mlagents-learn ml-agents/config/ppo/MyYamlFileName.yaml --run-id=MyId
```
This command will start a training following your YAML configuration file. 
To resume your training simply type:

```shell
mlagents-learn ml-agents/config/ppo/MyYamlFileName.yaml --resume
```

# My Training Environment

## Reinforcement Learning

## Combined Learning: Imitation + Reinforcement


# VR Scene Implementation


# Conclusion & Future Application

