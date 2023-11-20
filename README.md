# Számítógépbolt projektmunka

## Overview

This GitHub repository contains the project work completed by the 11th-grade team. The project involves creating a web-based computer store price list and configuration builder along with an administrative application for managing products using C#.

## Features

### Administrative Application (Gubacsi Áron[Team Member 1] - C#)

- Developed a C# application to input computer components and write the data to a text file.
- Each component's information is stored in the text file, with parameters separated by semicolons, such as:
  - Example: CPU;Intel Core i5-13600K; 3.5GHz 14-Core;130000
- Implemented a search feature to search for components based on type and name, price ranges, and create statistics.
- Additional functionality:
  - Check for existing components during input.
  - Modify the parameters of input data.
  - Complex search criteria.
  - Add components that differ from the listed ones.
  - Manage notebooks and desktops separately or together.

### Configuration Builder Webpage (Szkibák Szabolcs[Team Member 2] - JavaScript)

- Created a webpage listing computer components with the same parameters as described in Team Member 1's work.
- Developed a JavaScript-based configuration builder for assembling a computer configuration.
- Components can be selected via various methods, such as checkboxes, radio buttons, or by clicking on component images.
- When a component is selected, it is displayed separately on the page, and the configuration price is dynamically updated.
- A "Order" button checks if the configuration is complete; it highlights missing components and allows deselecting optional components.
- Dynamic functionality for real-time configuration updates.
- Optional features:
  - Responsive design.
  - Retrieve data from the text file provided by Team Member 1.
  - Search among products and display search results.
  - Create recommended configurations for different purposes (e.g., gaming, work, graphics editing).
  - Assemble both notebook and desktop configurations.

### Component Description Webpage (Berta Benedek[Team Member 3] - Html, Css)

- Developed a webpage for detailed descriptions of selectable components.
- Contains at least five different component descriptions.
- Features:
  - Responsive design.
  - Each product shows a short description initially, and clicking a button or the product name reveals a more detailed description.
- A comparison feature to compare two components of the same category in a separate section.
- Additional ideas:
  - Retrieve data from the text file provided by Team Member 1.
  - Highlight advantages (e.g., cheaper price or larger memory) in a different color when comparing parameters.
  - Distinguish between different manufacturers (e.g., Nvidia in green, AMD in red).
  - Search for specific products and display search results.

## Optional Enhancements

While the core features have been implemented, the project also includes optional enhancements that may be considered for future development.

## How to Use

To access and use the completed project, follow the instructions in each team member's section.

Enjoy exploring our computer store project!
