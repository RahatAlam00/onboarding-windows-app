<!-- cspell:ignore MVVM -->
# XAML Basics Reflection

## Basic XAML elements and syntax

XAML is an XML-based language used to define the user interface of a WPF application. Elements such as `Button`, `TextBox`, `TextBlock`, and `Grid` represent visual controls and layout containers.

Properties can be assigned directly inside an element. For example, a button can use properties such as `Content`, `Width`, `Background`, and `HorizontalAlignment`.

XAML elements can be nested inside layout panels. The root element of a WPF window is normally `Window`, with one main content element placed inside it.

## Layout panels

### Grid

A `Grid` arranges controls using rows and columns. It is useful for structured layouts such as forms, dashboards, and settings screens.

In my sample interface, I used a `Grid` to separate the title from the login form.

### StackPanel

A `StackPanel` arranges controls one after another, either vertically or horizontally.

I used a vertical `StackPanel` to arrange the username label, username field, password label, password field, and login button.

### DockPanel

A `DockPanel` attaches controls to the top, bottom, left, or right side of a container. It is useful for toolbars, menus, navigation panels, and status bars.

## Common WPF control properties

Some commonly used properties include:

- `Width` and `Height`
- `Margin`
- `Padding`
- `Background`
- `Foreground`
- `FontSize`
- `FontWeight`
- `HorizontalAlignment`
- `VerticalAlignment`
- `Content`
- `Text`

## Common WPF events

Common events include:

- `Click`
- `Loaded`
- `TextChanged`
- `SelectionChanged`
- `MouseEnter`
- `MouseLeave`

Events connect user actions in the interface to logic in the C# code-behind or ViewModel.

## Reflection

### How do different layout panels influence UI flexibility?

Different panels are useful for different layout problems. A `Grid` provides flexible row-and-column positioning and works well for structured interfaces. A `StackPanel` is easier for simple vertical or horizontal groups of controls. A `DockPanel` is useful when controls need to remain attached to the edges of a window.

Combining layout panels makes the interface easier to organise. In my example, the outer `Grid` controlled the overall structure, while the inner `StackPanel` arranged the form controls vertically.

### What challenges might arise when building responsive UIs with XAML?

Fixed widths and heights may look correct on one screen but may not adapt well to different window sizes, display scaling settings, or text lengths.

Responsive WPF layouts require careful use of automatic sizing, star sizing, alignment, margins, and stretching. Nested panels can also become difficult to understand if the layout becomes too complex.

Developers should avoid unnecessary fixed dimensions and test the interface at different window sizes and display scaling levels.

### How does separating UI and logic benefit application development?

Keeping UI definitions in XAML and application behaviour in C# makes the code easier to understand and maintain.

The layout can be modified without rewriting business logic, while the logic can be tested and changed without redesigning the interface. This separation also supports the MVVM pattern, where Views, ViewModels, and application data have clear responsibilities.

## What I learned from the practical task

I created a basic employee login interface using both a `Grid` and a `StackPanel`. The `Grid` divided the window into sections, while the `StackPanel` arranged the form controls vertically.

I also experimented with properties such as margins, font size, font weight, alignment, background colour, foreground colour, and control width.

The exercise helped me understand that WPF layouts are created by combining containers rather than placing every control at fixed coordinates.
