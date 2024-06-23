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

- Unity package ([`com.unity.ml-agents`](../com.unity.ml-agents/)) contains the
  Unity C# SDK that will be integrated into your Unity project.  This package contains
  a sample to help you get started with ML-Agents.
- Unity package
  ([`com.unity.ml-agents.extensions`](../com.unity.ml-agents.extensions/))
  contains experimental C#/Unity components that are not yet ready to be part
  of the base `com.unity.ml-agents` package. `com.unity.ml-agents.extensions`
  has a direct dependency on `com.unity.ml-agents`.
- Two Python packages:
  - [`mlagents`](../ml-agents/) contains the machine learning algorithms that
    enables you to train behaviors in your Unity scene. Most users of ML-Agents
    will only need to directly install `mlagents`.
  - [`mlagents_envs`](../ml-agents-envs/) contains a set of Python APIs to interact with
    a Unity scene. It is a foundational layer that facilitates data messaging
    between Unity scene and the Python machine learning algorithms.
    Consequently, `mlagents` depends on `mlagents_envs`.
- Unity [Project](https://github.com/Unity-Technologies/ml-agents/tree/main/Project/) that contains several
  [example environments](Learning-Environment-Examples.md) that highlight the
  various features of the toolkit to help you get started.

Consequently, to install and use the ML-Agents Toolkit you will need to:

- Install Unity (2023.2 or later)
- Install Python (3.10.12 or higher)
- Clone this repository (Recommended for the latest version and bug fixes)
  - __Note:__ If you do not clone the repository, then you will not be
  able to access the example environments and training configurations or the
  `com.unity.ml-agents.extensions` package. Additionally, the
  [Getting Started Guide](Getting-Started.md) assumes that you have cloned the
  repository.
- Install the `com.unity.ml-agents` Unity package
- Install the `com.unity.ml-agents.extensions` Unity package (Optional)
- Install the `mlagents-envs`
- Install the `mlagents` Python package

## Installation

## Training


# My Training Environment

## Reinforcement Learning

## Combined Learning: Imitation + Reinforcement


# VR Scene Implementation


# Conclusion & Future Application

