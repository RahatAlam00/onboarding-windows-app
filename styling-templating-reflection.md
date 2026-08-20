# Styling & Templating Reflection

## Styles and Control Templates

In WPF, a style provides a reusable collection of property values that can be applied to controls. This helps avoid repeating properties such as background colour, foreground colour, font size, padding, margin, width, and height on individual controls.

A control template goes further by defining the visual structure of a control. While a style can change properties of a button, a `ControlTemplate` can replace how the button is visually constructed while preserving its button behaviour.

For this exercise, I created a WPF project called `StylingTemplatingDemo` and compared a default button, a styled button, and a button using a custom control template.

## Custom Style Experiment

I created a reusable `StyledButton` style and applied properties including:

* `Background`
* `Foreground`
* `FontSize`
* `Padding`
* `Margin`
* `Width`
* `Height`

The styled button had a different appearance from the default WPF button without requiring these properties to be repeated directly on the button.

I experimented with the `FontSize` property by changing it from `16` to `20`. After running the application again, the button text was noticeably larger. This demonstrated how changing one property in a reusable style can control the appearance of controls that use that style.

## Control Template Experiment

I created a second style named `TemplatedButton`, based on the original button style, and added a custom `ControlTemplate`.

The template used a `Border` and `ContentPresenter` to create the visual structure of the button.

I used:

```xml
Background="{TemplateBinding Background}"
```

This allowed the border inside the template to use the `Background` property supplied by the button style instead of hard-coding the colour inside the template.

I initially used a `CornerRadius` of `14` and later changed it to `25`. When I ran the application again, the custom button appeared more rounded. This demonstrated that template properties can significantly change the visual structure of a control.

## Visual State Experiments

I also experimented with triggers inside the control template.

When `IsMouseOver` became `True`, the border opacity changed to `0.75`. I observed that hovering the mouse over the custom button made it partially transparent.

Initially, the pressed state also changed opacity. The difference between the hover and pressed states was not visually obvious, so I changed the `IsPressed` trigger to change the background to `Orange` instead.

After this change:

* The normal button had a dark blue background.
* Hovering over the button changed its opacity.
* Clicking and holding the button changed its background to orange.

This made the different visual states much easier to observe.

## Layout Experiment

After increasing the font size and corner radius, I noticed that the text `Rounded Template Button` was being clipped because the button was too narrow.

I increased the reusable button width from `220` to `300` and increased the window dimensions. After running the application again, the full button text was visible and the controls fitted comfortably inside the window.

This showed that styling changes can affect layout and that reusable UI elements need to be tested with their actual content.

## How Styles Enforce Consistency

Styles can enforce consistency because multiple controls can use the same shared definition instead of defining their appearance separately.

For example, if several buttons use the same style, properties such as font size, background, padding, and dimensions can be maintained in one place. Changing the shared style can then update all controls that use it.

This reduces duplicated XAML and makes it easier to maintain a consistent appearance throughout an application.

## Benefits and Challenges of Control Templates

A major benefit of control templates is the amount of control they provide over a control's appearance. A developer can substantially change the visual structure while keeping the underlying behaviour of the control.

Templates are also reusable, allowing the same custom appearance to be applied to multiple controls.

However, control templates are more complex than ordinary styles. When replacing the default template, the developer becomes responsible for defining the required visual structure and states.

For example, during this exercise I needed to explicitly define how the custom button should appear normally, when the mouse was over it, and when it was pressed.

## How Templating Improves Maintainability

Templating can improve maintainability by keeping reusable visual definitions separate from application logic.

Instead of recreating the same custom visual structure for every button, one template can be defined and reused. If the design needs to change later, the shared template can be updated instead of modifying every individual control.

Styles and templates therefore help separate presentation from application logic while reducing duplication and supporting a consistent UI.

## Conclusion

This exercise demonstrated that styles and control templates solve related but different UI problems.

Styles are useful for sharing property values and maintaining a consistent appearance. Control templates provide deeper customization by defining the visual structure of a control.

By experimenting with font size, corner radius, hover opacity, pressed-state background, button width, and window dimensions, I observed how both styling and templating changes directly affect the appearance and layout of a WPF application.
