# axiom_examples
Location for different example projects related to the aXiom chip.

## dll
Example C++ code that utilises the TH2 dll to communicate with aXiom through a protocol bridge. This example also includes code to control the mouse if enabled. See the README.md file in the dll folder for more information.

## hid_simple
Self-contained single C file that interacts with a hidraw (hidraw0) device.

## hid_test
Similar to Hid-Simple. This example uses the hidapi library to interact with a hidraw device.

## kernel_module
Raspberry Pi kernel module that communicates directly with the aXiom device (SPI or I2C) to send messages to the Linux input subsytem to emulate a multi-touch device.

## userspace_i2c
An example userspace driver that communicates to the aXiom device over I2C. Currently U34 is polled and it should be interrupt driven.
