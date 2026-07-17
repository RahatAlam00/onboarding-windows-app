def calculate_price_per_item(total_price, item_count):
    if total_price < 0:
        raise ValueError("Total price cannot be negative.")

    if item_count <= 0:
        raise ValueError("Item count must be greater than zero.")

    return total_price / item_count

